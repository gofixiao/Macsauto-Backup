using System.Windows.Forms;

namespace Macsauto.Presentation.WinForm.Common.Printing
{
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Text;

    public class LocalReportPrinter : IDisposable
    {
        private readonly LocalReport _report;
        private readonly PaperSize _paperSize;
        private readonly string _reportFullPath;
        private IList<Stream> _streams;
        private int _pageIndex;

        public LocalReportPrinter(string reportFullPath, PaperSize paperSize = null)
        {
            _reportFullPath = Application.StartupPath + @"\" + reportFullPath;
            _report = new LocalReport { ReportPath = _reportFullPath };
            _paperSize = paperSize ?? _report.GetDefaultPageSettings().PaperSize;
            _streams = new List<Stream>();
        }

        public void AddDataSource(string entityType, object data)
        {
            _report.DataSources.Add(new ReportDataSource(entityType, data));
        }

        public void Run()
        {
            Export();
            Print();
        }

        private void Print()
        {
            if (_streams == null || _streams.Count == 0)
            {
                throw new ApplicationException(@"No stream to print");
            }

            var printDocument = new PrintDocument
                {
                    PrintController = new StandardPrintController()
                };

            if (!printDocument.PrinterSettings.IsValid)
            {
                throw new ApplicationException(@"Cannot find printer");
            }

            printDocument.PrintPage += printDocument_PrintPage;

            _pageIndex = 0;

            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var pageImage = new Metafile(_streams[_pageIndex]);
            var adjustedRectangle = new Rectangle(
                e.PageBounds.Left - (int)e.PageSettings.HardMarginX,
                e.PageBounds.Top - (int)e.PageSettings.HardMarginY,
                e.PageBounds.Width,
                e.PageBounds.Height
            );

            e.Graphics.FillRectangle(Brushes.White, adjustedRectangle);

            e.Graphics.DrawImage(pageImage, adjustedRectangle);

            _pageIndex++;

            e.HasMorePages = (_pageIndex < _streams.Count);
        }

        private void Export()
        {
            Warning[] warnings;

            var deviceInfo = string.Format(
                @"<DeviceInfo>
                        <OutputFormat>EMF</OutputFormat>
                        <PageWidth>{0}in</PageWidth>
                        <PageHeight>{1}in</PageHeight>
                        <MarginTop>0.25in</MarginTop>
                        <MarginLeft>0.25in</MarginLeft>
                        <MarginRight>0.25in</MarginRight>
                        <MarginBottom>0.25in</MarginBottom>
                  </DeviceInfo>", _paperSize.Width, _paperSize.Height);

            _report.Render(@"Image", deviceInfo, CreateStream, out warnings);

            foreach (var stream in _streams)
            {
                stream.Position = 0;
            }
        }

        private Stream CreateStream(string name, string extension, Encoding encoding, string mimetype, bool willseek)
        {
            var stream = new MemoryStream();

            _streams.Add(stream);

            return stream;
        }

        public void Dispose()
        {
            if (_streams == null) return;

            foreach (var stream in _streams)
            {
                stream.Close();
            }

            _streams = null;
        }
    }
}
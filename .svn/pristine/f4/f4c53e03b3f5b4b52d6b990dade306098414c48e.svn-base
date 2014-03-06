namespace Macsauto.Infrastructure.Connector.Printing
{
    using System.Drawing.Printing;

    public static class PrinterManager
    {
        public static string[] GetInstalledPrinters()
        {
            var printers = PrinterSettings.InstalledPrinters;
            var printersArr = new string[printers.Count];

            printers.CopyTo(printersArr, 0);

            return printersArr;
        }
    }
}
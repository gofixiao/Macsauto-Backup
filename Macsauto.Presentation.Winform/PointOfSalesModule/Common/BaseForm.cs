namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Common
{
    using System;
    using System.Windows.Forms;

    public abstract class BaseForm : Form
    {
        protected BaseForm()
        {
            this.Load += BaseForm_Load;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
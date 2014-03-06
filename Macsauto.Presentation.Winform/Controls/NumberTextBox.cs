using System.Windows.Forms;

namespace Macsauto.Presentation.WinForm.Controls
{
    public class NumberTextBox : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = false;
            }

            if (e.KeyChar == '.' && Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
    }
}
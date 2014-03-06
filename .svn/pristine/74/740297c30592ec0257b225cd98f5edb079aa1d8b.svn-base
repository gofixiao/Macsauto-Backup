using System.Globalization;
using System.Windows.Forms;
using Macsauto.Infrastructure.Helper.Extension;

namespace Macsauto.Presentation.WinForm.Controls
{
    public class NumButton : Button
    {
        private readonly string _currencySymbol = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
        
        public bool IsCurrency { get; set; }
        public TextBox Target { get; set; }
        public long Value { get; set; }

        protected override void OnClick(System.EventArgs e)
        {
            string text = Target.Text;

            if (Target != null)
            {
                if (IsCurrency)
                {
                    long value = text.ParseFromCurrency();

                    Target.Text = string.Format(@"{0} {1:D},00", _currencySymbol, (value + Value));
                }
                else
                {
                    long value = long.Parse(text);

                    Target.Text = string.Format(@"{0:D}",
                                                long.Parse(value.ToString(CultureInfo.InvariantCulture) +
                                                Value.ToString(CultureInfo.InvariantCulture)));
                }
            }

            base.OnClick(e);
        }
    }
}
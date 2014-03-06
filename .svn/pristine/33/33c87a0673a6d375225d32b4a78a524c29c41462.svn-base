namespace Macsauto.Infrastructure.Helper.Extension
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Text;

    public static class StringExtension
    {
        private static readonly string CurrencySymbol = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
        private static readonly string DecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static byte[] ToBytes(this string value)
        {
            return Encoding.ASCII.GetBytes(value);
        }

        
        public static long ParseFromCurrency(this string value)
        {
            string newValue = value;

            if (newValue.IndexOf(DecimalSeparator, System.StringComparison.Ordinal) > -1)
            {
                newValue = newValue.Substring(0,
                                              newValue.Length -
                                              newValue.IndexOf(DecimalSeparator, System.StringComparison.Ordinal) + 1);
            }

            if (newValue.IndexOf(CurrencySymbol, System.StringComparison.Ordinal) > -1)
            {
                newValue = newValue.Replace(CurrencySymbol, @"");
            }

            newValue = newValue.Trim();

            return long.Parse(newValue);
        }

        public static string ToCamelCase(this string value)
        {
            string newValue = value;

            newValue = char.ToLowerInvariant(newValue[0]) + newValue.Substring(1);

            return newValue;
        }
    }
}
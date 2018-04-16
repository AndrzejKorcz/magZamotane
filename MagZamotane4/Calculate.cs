using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagZamotane4
{
    public static class Calculate
    {
        #region privateMethods

        private static string defaultAmountFormat = "0,00";

        private static double calculatePriceValue(double nettoPrice, double quantity)
        {
            return nettoPrice * quantity;
        }

        private static double calculateGrossPrice(double nettoPrice, double vatPercent)
        {
            var vat = vatPercent / 100.00;
            return nettoPrice + (nettoPrice * vat);
        }

        private static double calculateMargin(double grossPrice, double price)
        {
            return price - grossPrice;
        }

        private static double calculateReduceAmount(double quantity, double value)
        {
            return quantity - value;
        }

        #endregion

        public static string calculateReduceAmount(string quantity, string value)
        {
            if (string.IsNullOrEmpty(quantity)) quantity = "0";
            if (string.IsNullOrEmpty(value)) value = "0";

            return calculateReduceAmount((double.Parse(quantity.Replace('.', ','), CultureInfo.CurrentCulture)), (double.Parse(value.Replace('.', ','), CultureInfo.CurrentCulture))).ToString("N2").ToString();
        }

        public static string calculatePriceValue(string nettoPrice, string quantity)
        {
            if (string.IsNullOrEmpty(nettoPrice)) nettoPrice = defaultAmountFormat;
            if (string.IsNullOrEmpty(quantity)) quantity = "0";

            return calculatePriceValue((double.Parse(nettoPrice.Replace('.', ','), CultureInfo.CurrentCulture)), (double.Parse(quantity.Replace('.', ','), CultureInfo.CurrentCulture))).ToString("N2").ToString();
        }

        public static string calculateGrossPrice(string nettoPrice, string vatPercent)
        {
            if (string.IsNullOrEmpty(nettoPrice)) nettoPrice = defaultAmountFormat;
            if (string.IsNullOrEmpty(vatPercent)) vatPercent = "23";

            return calculateGrossPrice(double.Parse(nettoPrice.Replace('.', ','), CultureInfo.CurrentCulture), Convert.ToDouble(vatPercent)).ToString("N2").ToString();
        }

        public static string calculateMargin(string grossPrice, string price)
        {
            if (string.IsNullOrEmpty(grossPrice)) grossPrice = defaultAmountFormat;
            if (string.IsNullOrEmpty(price)) price = defaultAmountFormat;

            return calculateMargin(double.Parse(grossPrice.Replace('.', ','), CultureInfo.CurrentCulture), double.Parse(price.Replace('.', ','), CultureInfo.CurrentCulture)).ToString("N2").ToString();
        }

    }
}


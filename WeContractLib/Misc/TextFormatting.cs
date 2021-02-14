namespace WeContractLib.Misc
{
    public static class TextFormatting
    {
        public static string KiloFormat(this double num, bool forcePrefix = false)
        {
            if (num >= 100000000)
                return (num / 1000000).ToString("#,0M");

            if (num >= 10000000)
                return (num / 1000000).ToString("0.#") + "M";

            if (num >= 100000)
                return (num / 1000).ToString("#,0.00K");

            if (num >= 10000 || forcePrefix)
                return (num / 1000).ToString("#,0.##") + "K";

            return num.ToString("#,0.##");
        }

        public static string CurrencyFormat(double number, bool useCurrencyPrefix = false)
        {
            if (useCurrencyPrefix)
            {
                return number.KiloFormat();
            }
            return number.ToString("### ### ##0.0#");
        }

        public static string PhoneNumberFormat(uint number)
        {
            return number.ToString("000 00 000");
        }
    }
}

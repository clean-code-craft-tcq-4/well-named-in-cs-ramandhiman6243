namespace TelCo.ColorCoder
{
    /// <summary>
    /// Converts color map to printable string
    /// from color pair and/or color pair number
    /// </summary>
    internal class ColorMapToStringFormatter
    {
        /// <summary>
        /// String output format
        /// </summary>
        private const string OutputFormat = "Pair Number: {0}, Colors: {1}";

        /// <summary>
        /// Converts color pair to string with specified format
        /// </summary>
        /// <param name="colorPair">color pair input</param>
        /// <returns>Formatted color string</returns>
        public static string GetFromColorPair(ColorPair colorPair)
        {
            int pairNumber = PairNumberFromColor.GetPairNumberFromColor(colorPair);
            return FormatIntoString(pairNumber, colorPair);
        }

        /// <summary>
        /// Converts pair number to string with specified format
        /// </summary>
        /// <param name="pairNumber">pair number input</param>
        /// <returns>Formatted color string</returns>
        public static string GetFromPairNumber(int pairNumber)
        {
            ColorPair colorPair = ColorFromPairNumber.GetColorFromPairNumber(pairNumber);
            return FormatIntoString(pairNumber, colorPair);
        }

        /// <summary>
        /// Converts pair number and color pair to string with specified format
        /// </summary>
        /// <param name="pairNumber">Color Pair Number</param>
        /// <param name="colorPair">Color Pair Object</param>
        /// <returns>Formatted color string</returns>
        public static string FormatIntoString(int pairNumber, ColorPair colorPair)
        {
            string output = string.Format(OutputFormat, pairNumber, colorPair);
            return output;
        }
    }
}
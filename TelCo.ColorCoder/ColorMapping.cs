using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Data store for color mapping
    /// </summary>
    internal class ColorMapping
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] colorMapMajor;

        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] colorMapMinor;

        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static ColorMapping()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}

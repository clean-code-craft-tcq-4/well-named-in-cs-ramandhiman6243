using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main function
        /// Calls Tests class to perform all tests
        /// Demonstrates the use of ColorMapToStringFormatter
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //Perform all tests
            Tests.PerformAllTests();


            //ColorMapToStringFormatter demonstration
            //From pair number
            Console.WriteLine(ColorMapToStringFormatter.GetFromPairNumber(9) + "\n");

            //From color pair object
            ColorPair colorPair = new ColorPair();
            colorPair.majorColor = Color.Black;
            colorPair.minorColor = Color.Green;
            Console.WriteLine(ColorMapToStringFormatter.GetFromColorPair(colorPair) + "\n");
        }
    }
}

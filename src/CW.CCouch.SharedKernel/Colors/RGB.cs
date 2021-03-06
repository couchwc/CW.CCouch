using CW.CCouch.SharedKernel.Conversions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CCouch.SharedKernel.Colors
{

    /// <summary>
    /// 
    /// </summary>
    public class RGB
    {

        // Constants
        public const int MaximumValue =
            255;

        public const int MinimumValue =
            0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r">
        /// 
        /// </param>
        /// <param name="g">
        /// 
        /// </param>
        /// <param name="b">
        /// 
        /// </param>
        /// <returns>
        /// A hexadecimal representation of the given rgb values.
        /// </returns>
        /// <remarks>
        /// Result will always be 6 characters long.
        /// 
        /// Valid decimal values for RGB are 0 - 255. Any values that fall out 
        /// of that range must be rounded to the closest valid value.
        /// 
        /// Other solutions: https://www.codewars.com/kata/513e08acc600c94f01000001/solutions/csharp
        /// </remarks>
        public static string ToHexidecimal(
            int r,
            int g,
            int b)
        {

            var rHex =
                Hexidecimal.ConvertRGB(
                    value: r);

            var gHex =
                Hexidecimal.ConvertRGB(
                    value: g);

            var bHex =
                Hexidecimal.ConvertRGB(
                    value: b);

            var result =
                $"{rHex}{gHex}{bHex}";

            return result;

        }

    }

}

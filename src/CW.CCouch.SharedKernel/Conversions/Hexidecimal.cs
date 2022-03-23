using CW.CCouch.SharedKernel.Integers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CCouch.SharedKernel.Conversions
{

    /// <summary>
    /// 
    /// </summary>
    public static class Hexidecimal
    {

        // Constants
        const int MaximumIntegerValue =
            255;

        const int MinimumIntegerValue =
            0;

        /// <summary>
        /// Formats the given RGB value into hexidecimal form using the .NET
        /// "X2" string format.
        /// </summary>
        /// <param name="value">
        /// An integer value between the range of 0 through 255.
        /// </param>
        /// <returns>
        /// A string representing the hexidecimal value.
        /// </returns>
        /// <remarks>
        /// Currently works for integers from <see cref="MinimumIntegerValue"/> 
        /// through <see cref="MaximumIntegerValue"/>
        /// </remarks>
        public static string ConvertRGB(
            int value)
        {

            var newValue =
                value.Clamp(
                    maximum: MaximumIntegerValue,
                    minimum: MinimumIntegerValue);

            var hexValue =
                newValue.ToString("X2");

            return hexValue;

        }

    }

}

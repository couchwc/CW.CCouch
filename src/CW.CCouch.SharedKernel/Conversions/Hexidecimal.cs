using CW.CCouch.SharedKernel.Colors;
using CW.CCouch.SharedKernel.Extensions;
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
                    maximum: RGB.MaximumValue,
                    minimum: RGB.MinimumValue);

            var hexValue =
                newValue.ToString("X2");

            return hexValue;

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CCouch.Seeding.Exersices
{

    /// <summary>
    /// 
    /// </summary>
    internal static class RGBToHexConversion
    {

        /// <summary>
        /// 
        /// </summary>
        public static string Exercise()
        {

            const string WhiteHexColor =
                "FFFFFF";

            var value =
                CW.CCouch.SharedKernel.Colors.RGB.ToHexidecimal(
                    r: 255,
                    g: 255,
                    b: 255);

            var areEqual = string.Equals(
                a: WhiteHexColor,
                b: value);

            var outputBuilder =
                new StringBuilder();

            outputBuilder.AppendLine($"--------------------------------------------------");
            outputBuilder.Append($"{DateTime.Now.ToString(CW.CCouch.SharedKernel.Formatting.Constants.FullDateTimeFormat)} ");
            outputBuilder.AppendLine($"{nameof(RGBToHexConversion)}");
            outputBuilder.AppendLine();
            outputBuilder.AppendLine($"Output:");
            outputBuilder.AppendLine($"{WhiteHexColor} is equal to {value} = {areEqual}");
            outputBuilder.Append($"--------------------------------------------------");

            var output =
                outputBuilder.ToString();

            return output;

        }

    }

}

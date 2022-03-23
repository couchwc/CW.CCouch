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
    internal class RGBToHexConversion
    {

        /// <summary>
        /// 
        /// </summary>
        public void Exercise()
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

        }

    }

}

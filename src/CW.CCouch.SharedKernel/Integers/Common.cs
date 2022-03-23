using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CCouch.SharedKernel.Integers
{

    /// <summary>
    /// 
    /// </summary>
    public static class Common
    {

        /// <summary>
        /// Clamp the given value inside the given minimum and maximum range.
        /// </summary>
        /// <param name="maximum">
        /// 
        /// </param>
        /// <param name="minimum">
        /// 
        /// </param>
        /// <param name="value">
        /// 
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        public static int Clamp(
            this int value,
            int maximum,
            int minimum)
        {

            // Option 02
            var result =
                // If the value is less than the minimum,
                (value < minimum)
                // then return the minimum.
                ? minimum
                // Else if the value is greater than the maximum,
                : (value > maximum)
                // then return the maximum.
                ? maximum
                // Else, return the value
                : value;

            // Option 01
            //var result =
            //    value;

            //if (value > maximum)
            //    result =
            //        maximum;
            //else if (value < minimum)
            //    result =
            //        minimum;

            return result;

        }

    }

}

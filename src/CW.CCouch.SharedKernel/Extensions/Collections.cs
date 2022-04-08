using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CCouch.SharedKernel.Extensions
{

    /// <summary>
    /// 
    /// </summary>
    public static class Collections
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        public static string GetCommaSeparatedString(
            this IEnumerable<int>? value)
        {

            var output =
                (value is not null
                ? $"{{{string.Join(",", value)}}}"
                : $"null");

            return output;

        }

    }

}

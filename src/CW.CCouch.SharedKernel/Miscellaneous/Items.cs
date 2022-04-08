using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CCouch.SharedKernel.Miscellaneous
{
    
    /// <summary>
    /// 
    /// </summary>
    public static class Items
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static IEnumerable<int> SortNumbers(
            IEnumerable<int>? values)
        {

            if (values is null)
                return Enumerable.Empty<int>();

            var sortedValues =
                new List<int>();
            
            sortedValues.AddRange(
                collection: values);

            sortedValues.Sort();

            return sortedValues;

        }

    }

}

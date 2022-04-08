using CW.CCouch.SharedKernel.Extensions;
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
    internal static class SortingIntegerCollection
    {

        /// <summary>
        /// 
        /// </summary>
        public static string Exercise()
        {

            var value =
                new int[] { 1, 2, 3, 10, 5 };

            var actual =
                CW.CCouch.SharedKernel.Miscellaneous.Items.SortNumbers(
                    values: value);

            var expected =
                new int[] { 1, 2, 3, 5, 10 };

            var outputBuilder =
                new StringBuilder();

            var valueOutput =
                value.GetCommaSeparatedString();

            var actualOutput =
                actual.GetCommaSeparatedString();

            var expectedOutput =
                expected.GetCommaSeparatedString();

            var areEqual =
                actualOutput.Equals(
                    value: expectedOutput);

            outputBuilder.AppendLine($"--------------------------------------------------");
            outputBuilder.Append($"{DateTime.Now.ToString(CW.CCouch.SharedKernel.Formatting.Constants.FullDateTimeFormat)} ");
            outputBuilder.AppendLine($"{nameof(SortingIntegerCollection)}");
            outputBuilder.AppendLine();
            outputBuilder.AppendLine($"Output:");
            outputBuilder.AppendLine($"Initial: {valueOutput};");
            outputBuilder.AppendLine($"Actual: {actualOutput};");
            outputBuilder.AppendLine($"Expected: {expectedOutput};");
            outputBuilder.AppendLine($"Are Equal = {areEqual}");
            outputBuilder.Append($"--------------------------------------------------");

            var output =
                outputBuilder.ToString();

            return output;

        }

    }

}

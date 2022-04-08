using CW.CCouch.SharedKernel.Extensions;
using System;
using System.Collections.Generic;
using Xunit;

namespace CW.CCouch.XUnit.UnitTests.Exercises
{

    /// <summary>
    /// 
    /// </summary>
    public class SortingNumbersTests
    {

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void SortingIntegerCollectionTests()
        {

            checkNums(new int[] { 1, 2, 3, 10, 5 }, new int[] { 1, 2, 3, 5, 10 });
            checkNums(null, Array.Empty<int>());
            checkNums(new int[] { }, Array.Empty<int>());
            checkNums(new int[] { 20, 2, 10 }, new int[] { 2, 10, 20 });
            checkNums(new int[] { 2, 20, 10 }, new int[] { 2, 10, 20 });
            checkNums(new int[] { 2, 10, 20 }, new int[] { 2, 10, 20 });

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expectedValue"></param>
        private void checkNums(
            IEnumerable<int>? value,
            IEnumerable<int> expectedValue)
        {

            var actual =
                CW.CCouch.SharedKernel.Miscellaneous.Items.SortNumbers(
                    values:value) ;

            Assert.Equal(
                expected: expectedValue,
                actual: actual);

            var output =
                actual.GetCommaSeparatedString();

            System.Diagnostics.Debug.WriteLine($"{output}");

        }

    }

}

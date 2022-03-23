using CW.CCouch.SharedKernel.Colors;
using CW.CCouch.SharedKernel.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CW.CCouch.XUnit.UnitTests.Projects.SharedKernelz.Extensions
{

    /// <summary>
    /// 
    /// </summary>
    public class IntegerTests
    {

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void FixedIntegerClampTest()
        {

            int initialValue =
                300;

            var expectedValue =
                255;

            var newValue =
                initialValue.Clamp(
                    maximum: RGB.MaximumValue,
                    minimum: RGB.MinimumValue);

            Assert.Equal(
                expected: expectedValue,
                actual: newValue);

        }

    }

}

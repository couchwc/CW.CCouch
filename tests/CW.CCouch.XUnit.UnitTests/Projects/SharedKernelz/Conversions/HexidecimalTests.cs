using CW.CCouch.SharedKernel.Colors;
using CW.CCouch.SharedKernel.Conversions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CW.CCouch.XUnit.UnitTests.Projects.SharedKernelz.Conversions
{
    
    /// <summary>
    /// 
    /// </summary>
    public class HexidecimalTests
    {

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void FixedRGBConversionTests()
        {

            const string FFHexValue =
                "FF";

            const string OOHexValue =
                "00";

            Assert.Equal(
                expected: FFHexValue,
                actual: Hexidecimal.ConvertRGB(
                    value:255));

            Assert.Equal(
                expected: OOHexValue,
                actual: Hexidecimal.ConvertRGB(
                    value: 0));

        }

    }

}

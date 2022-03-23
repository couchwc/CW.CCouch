using CW.CCouch.SharedKernel.Colors;
using Xunit;

namespace CW.CCouch.XUnit.UnitTests.Projects.SharedKernelz.Colors
{

    /// <summary>
    /// 
    /// </summary>
    public class RGBTests
    {

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void FixedRGBConversionTests()
        {

            // Constants
            const string BlackHexColor =
                "000000";

            const string DarkSkyBlueHexColor =
                "90C3D4";

            const string DarkVioletHexColor =
                "9400D3";

            const string SinopiaHexColor =
                "D4350C";

            const string WhiteHexColor =
                "FFFFFF";

            Assert.Equal(
                expected: WhiteHexColor,
                actual: RGB.ToHexidecimal(
                    r: 255,
                    g: 255,
                    b: 255));

            Assert.Equal(
                expected: WhiteHexColor,
                actual: RGB.ToHexidecimal(
                    r: 255,
                    g: 255,
                    b: 300));

            Assert.Equal(
                expected: BlackHexColor,
                actual: RGB.ToHexidecimal(
                    r: 0,
                    g: 0,
                    b: 0));

            Assert.Equal(
                expected: DarkVioletHexColor,
                actual: RGB.ToHexidecimal(
                    r: 148,
                    g: 0,
                    b: 211));

            // Handle negative numbers.
            Assert.Equal(
                expected: DarkVioletHexColor,
                actual: RGB.ToHexidecimal(
                    r: 148,
                    g: -20,
                    b: 211));

            Assert.Equal(
                expected: DarkSkyBlueHexColor,
                actual: RGB.ToHexidecimal(
                    r: 144,
                    g: 195,
                    b: 212));

            // Consider single hex digit numbers.
            Assert.Equal(
                expected: SinopiaHexColor,
                actual: RGB.ToHexidecimal(
                    r: 212,
                    g: 53,
                    b: 12));

        }

    }

}

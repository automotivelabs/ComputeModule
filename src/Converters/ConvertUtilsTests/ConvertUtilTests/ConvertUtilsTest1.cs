using ConvertUtils;
using System;
using Xunit;

namespace ConvertUtilTests
{
    // Tests
    public class ConvertUtilsTest1
    {
        [Fact]
        public void MilesToKilometers_Ok()
        {
            //Test1
            Assert.Equal(ConvertUtils.ConvertUtils.MilesToKilometers(1), ConvertUtils.ConvertUtils.MILE_KILOMETER_RATIO);
        }

        [Fact]
        public void MilesToKilometers_Ko()
        {
            //Test1
            Assert.NotEqual(ConvertUtils.ConvertUtils.MilesToKilometers(2), ConvertUtils.ConvertUtils.MILE_KILOMETER_RATIO);
        }

        [Fact]
        public void KilometersToMiles_Ok()
        {
            //Test1
            Assert.Equal(ConvertUtils.ConvertUtils.KilometersToMiles(1.609344), Convert.ToDouble(1));
        }
        [Fact]
        public void KilometersToMiles_Ko()
        {
            //Test1
            Assert.NotEqual(ConvertUtils.ConvertUtils.KilometersToMiles(1.62222), Convert.ToDouble(1));
        }
    }
}

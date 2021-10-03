using ConvertUtils;
using System;
using Xunit;

namespace ConvertUtilTests
{
    public class ConvertUtilsTest1
    {
        //Test pipeline for test
        [Fact]
        public void Test1()
        {
            Assert.Equal(ConvertUtils.ConvertUtils.MilesToKilometers(1), ConvertUtils.ConvertUtils.MILE_KILOMETER_RATIO);
        }
    }
}

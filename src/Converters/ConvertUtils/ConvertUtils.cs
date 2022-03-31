using System;

namespace ConvertUtils
{
    public static class ConvertUtils
    {
        public const double MILE_KILOMETER_RATIO = 1.609344;

        public static double MilesToKilometers(double value)
        {
            return value * MILE_KILOMETER_RATIO;
        }
        public static double KilometersToMiles(double value)
        {
            return value / MILE_KILOMETER_RATIO;
        }

/*
    <summary>
        Converts temperature from Celsius to Fahrenheit.
        <param name="value">Temperature in Celsius</param>
        <returns>Temperature in Fahrenheit</returns>    
    </summary>

*/
        public static double CelsiusToFahrenheit(double value)
        {
            return value * 1.8 + 32;
        }

        public static double FahrenheitToCelsius(double value)
        {
            return (value - 32) / 1.8;
        }
        
        public  static double ConvertToDegree(double rad)
        {
            return (180 / Math.PI) * rad;
        }
        
        public static double ConvertToRadians(double angle)
        {
            return (System.Math.PI / 180) * angle;
        }
    }
}

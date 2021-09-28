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

    }
}

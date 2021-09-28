using System;

namespace ConvertUtils
{
    public static class ConvertUtils
    {
        public const double MiKmRatio = 1.609344;

        public static double MilesToKilometers(double value)
        {
            return value * MiKmRatio;
        }
        public static double KilometersToMiles(double value)
        {
            return value / MiKmRatio;
        }

    }
}

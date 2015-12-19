using System;
using System.Diagnostics;

namespace RegexTester.Helpers
{
    public static class ValueHelper
    {
        public static Double ConvertTicksToNanoseconds(Int64 ticks)
        {
            return Convert.ToDouble(ticks) / Convert.ToDouble(Stopwatch.Frequency) * Math.Pow(10, 9);
        }
    }
}
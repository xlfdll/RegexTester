using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

using RegexTester.Properties;

namespace RegexTester
{
    internal static class FieldHelper
    {
        internal static readonly Regex ResultNodeRegex = new Regex(String.Format(Resources.ResultNodeTextFormat, @"(?<Value>.*?)", @"(?<Index>\d+)"), RegexOptions.Compiled);

        internal static readonly Double NanoSecondPerTick = Convert.ToDouble(1000 * 1000 * 1000) / Convert.ToDouble(Stopwatch.Frequency);

        internal const Int32 TickCycleCount = 101;
    }
}
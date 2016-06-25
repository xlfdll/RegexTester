using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

using RegexTester.Data;

namespace RegexTester.Helpers
{
    public static class RegexHelper
    {
        public static RegexResult Match(RegexInput input)
        {
            Regex regex = new Regex(input.RegexPattern, input.Options, Settings.Main.RegexOperationTimeout);
            Stopwatch stopWatch = new Stopwatch();
            MatchCollection matchCollection = null;

            try
            {
                stopWatch.Start();
                matchCollection = regex.Matches(input.Text);
            }
            finally
            {
                stopWatch.Stop();
            }

            RegexResult regexResult = new RegexResult();

            foreach (Match match in matchCollection)
            {
                RegexMatch regexMatch = new RegexMatch(match.Value, match.Index);

                foreach (Group group in match.Groups)
                {
                    RegexMatch groupMatch = new RegexMatch(group.Value, group.Index);

                    foreach (Capture capture in group.Captures)
                    {
                        RegexMatch captureMatch = new RegexMatch(capture.Value, capture.Index);

                        groupMatch.Children.Add(captureMatch);
                    }

                    regexMatch.Children.Add(groupMatch);
                }

                regexResult.Results.Add(regexMatch);
            }

            regexResult.Update(stopWatch.ElapsedTicks);

            return regexResult;
        }

        public static String[] Split(RegexInput input)
        {
            Regex regex = new Regex(input.RegexPattern, input.Options, Settings.Main.RegexOperationTimeout);

            return regex.Split(input.Text);
        }

        public static String Replace(RegexInput input)
        {
            Regex regex = new Regex(input.RegexPattern, input.Options, Settings.Main.RegexOperationTimeout);

            return regex.Replace(input.Text, input.ReplacePattern);
        }

        public static Int64 Measure(RegexInput input)
        {
            Regex regex = new Regex(input.RegexPattern, input.Options, Settings.Main.RegexOperationTimeout);
            Stopwatch stopWatch = new Stopwatch();

            try
            {
                stopWatch.Start();
                regex.IsMatch(input.Text);
            }
            finally
            {
                stopWatch.Stop();
            }

            return stopWatch.ElapsedTicks;
        }
    }
}
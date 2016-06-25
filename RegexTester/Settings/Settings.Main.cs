using System;
using System.Text.RegularExpressions;

using RegexTester.Helpers;

namespace RegexTester
{
    public static partial class Settings
    {
        public static class Main
        {
            static Main()
            {
                ApplicationHelper.Settings.Current.TryAddValue("Main", "RegexOperationTimeout", Regex.InfiniteMatchTimeout.ToString());
            }

            public static TimeSpan RegexOperationTimeout
            {
                get
                {
                    return TimeSpan.Parse(ApplicationHelper.Settings.Current["Main"]["RegexOperationTimeout"]);
                }
                set
                {
                    ApplicationHelper.Settings.Current["Main"]["RegexOperationTimeout"] = value.ToString();
                }
            }
        }
    }
}
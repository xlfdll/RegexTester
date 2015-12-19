using System;
using System.Text.RegularExpressions;

using RegexTester.Helpers;

namespace RegexTester.Data.Configuration
{
    public static partial class ConfigurationData
    {
        public static class Main
        {
            static Main()
            {
                ConfigurationHelper.AddValue("Main", "RegexOperationTimeout", Regex.InfiniteMatchTimeout.ToString());
            }

            public static TimeSpan RegexOperationTimeout
            {
                get
                {
                    return TimeSpan.Parse(ConfigurationHelper.Current["Main"]["RegexOperationTimeout"]);
                }
                set
                {
                    ConfigurationHelper.Current["Main"]["RegexOperationTimeout"] = value.ToString();
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows;

using RegexTester.Helpers;

namespace RegexTester.Data.Configuration
{
    static partial class ConfigurationData
    {
        public static class History
        {
            static History()
            {
                ConfigurationHelper.AddValue("History", "RecentRegexPatternCount", "10");
                ConfigurationHelper.AddValue("History", "RecentReplacePatternCount", "10");

                ConfigurationData.History.RecentRegexPatterns = new List<String>();
                ConfigurationData.History.RecentReplacePatterns = new List<String>();

                for (Int32 i = 0; i < ConfigurationData.History.RecentRegexPatternCount; i++)
                {
                    ConfigurationHelper.AddValue("History", "RecentRegexPattern" + (i + 1).ToString(), String.Empty);
                    ConfigurationData.History.RecentRegexPatterns.Add(ConfigurationHelper.Current["History"]["RecentRegexPattern" + (i + 1).ToString()]);
                }

                for (Int32 i = 0; i < ConfigurationData.History.RecentReplacePatternCount; i++)
                {
                    ConfigurationHelper.AddValue("History", "RecentReplacePattern" + (i + 1).ToString(), String.Empty);
                    ConfigurationData.History.RecentReplacePatterns.Add(ConfigurationHelper.Current["History"]["RecentReplacePattern" + (i + 1).ToString()]);
                }
            }

            public static Int32 RecentRegexPatternCount
            {
                get
                {
                    return Convert.ToInt32(ConfigurationHelper.Current["History"]["RecentRegexPatternCount"]);
                }
                set
                {
                    ConfigurationHelper.Current["History"]["RecentRegexPatternCount"] = value.ToString();
                }
            }
            public static Int32 RecentReplacePatternCount
            {
                get
                {
                    return Convert.ToInt32(ConfigurationHelper.Current["History"]["RecentReplacePatternCount"]);
                }
                set
                {
                    ConfigurationHelper.Current["History"]["RecentReplacePatternCount"] = value.ToString();
                }
            }

            public static List<String> RecentRegexPatterns { get; private set; }
            public static List<String> RecentReplacePatterns { get; private set; }

            public static void AddRecentRegexPattern(String item)
            {
                Int32 index = ConfigurationData.History.RecentRegexPatterns.IndexOf(item);

                if (index != -1)
                {
                    ConfigurationData.History.RecentRegexPatterns.RemoveAt(index);
                }

                ConfigurationData.History.RecentRegexPatterns.Insert(0, item);

                if (ConfigurationData.History.RecentRegexPatterns.Count > ConfigurationData.History.RecentRegexPatternCount)
                {
                    ConfigurationData.History.RecentRegexPatterns.RemoveAt(ConfigurationData.History.RecentRegexPatterns.Count - 1);
                }

                for (Int32 i = 0; i < ConfigurationData.History.RecentRegexPatternCount; i++)
                {
                    ConfigurationHelper.Current["History"]["RecentRegexPattern" + (i + 1).ToString()] = ConfigurationData.History.RecentRegexPatterns[i];
                }
            }
            public static void AddRecentReplacePattern(String item)
            {
                Int32 index = ConfigurationData.History.RecentReplacePatterns.IndexOf(item);

                if (index != -1)
                {
                    ConfigurationData.History.RecentReplacePatterns.RemoveAt(index);
                }

                ConfigurationData.History.RecentReplacePatterns.Insert(0, item);

                if (ConfigurationData.History.RecentReplacePatterns.Count > ConfigurationData.History.RecentReplacePatternCount)
                {
                    ConfigurationData.History.RecentReplacePatterns.RemoveAt(ConfigurationData.History.RecentReplacePatterns.Count - 1);
                }

                for (Int32 i = 0; i < ConfigurationData.History.RecentReplacePatternCount; i++)
                {
                    ConfigurationHelper.Current["History"]["RecentReplacePattern" + (i + 1).ToString()] = ConfigurationData.History.RecentReplacePatterns[i];
                }
            }
        }
    }
}
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
                ApplicationHelper.Settings.Current.TryAddValue("History", "RecentRegexPatternCount", "10");
                ApplicationHelper.Settings.Current.TryAddValue("History", "RecentReplacePatternCount", "10");

                ConfigurationData.History.RecentRegexPatterns = new List<String>();
                ConfigurationData.History.RecentReplacePatterns = new List<String>();

                for (Int32 i = 0; i < ConfigurationData.History.RecentRegexPatternCount; i++)
                {
                    ApplicationHelper.Settings.Current.TryAddValue("History", "RecentRegexPattern" + (i + 1).ToString(), String.Empty);
                    ConfigurationData.History.RecentRegexPatterns.Add(ApplicationHelper.Settings.Current["History"]["RecentRegexPattern" + (i + 1).ToString()]);
                }

                for (Int32 i = 0; i < ConfigurationData.History.RecentReplacePatternCount; i++)
                {
                    ApplicationHelper.Settings.Current.TryAddValue("History", "RecentReplacePattern" + (i + 1).ToString(), String.Empty);
                    ConfigurationData.History.RecentReplacePatterns.Add(ApplicationHelper.Settings.Current["History"]["RecentReplacePattern" + (i + 1).ToString()]);
                }
            }

            public static Int32 RecentRegexPatternCount
            {
                get
                {
                    return Convert.ToInt32(ApplicationHelper.Settings.Current["History"]["RecentRegexPatternCount"]);
                }
                set
                {
                    ApplicationHelper.Settings.Current["History"]["RecentRegexPatternCount"] = value.ToString();
                }
            }
            public static Int32 RecentReplacePatternCount
            {
                get
                {
                    return Convert.ToInt32(ApplicationHelper.Settings.Current["History"]["RecentReplacePatternCount"]);
                }
                set
                {
                    ApplicationHelper.Settings.Current["History"]["RecentReplacePatternCount"] = value.ToString();
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
                    ApplicationHelper.Settings.Current["History"]["RecentRegexPattern" + (i + 1).ToString()] = ConfigurationData.History.RecentRegexPatterns[i];
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
                    ApplicationHelper.Settings.Current["History"]["RecentReplacePattern" + (i + 1).ToString()] = ConfigurationData.History.RecentReplacePatterns[i];
                }
            }
        }
    }
}
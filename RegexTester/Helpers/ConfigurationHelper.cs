using System;

using Xlfdll.Core;
using Xlfdll.Windows.Configuration;

namespace RegexTester.Helpers
{
    public static class ConfigurationHelper
    {
        static ConfigurationHelper()
        {
            ConfigurationHelper.Processor = new RegistryConfigurationProcessor(@"Xlfdll\RegexTester", RegistryConfigurationScope.User);
            ConfigurationHelper.Current = ConfigurationHelper.Processor.LoadConfiguration();
        }

        public static Configuration Current { get; private set; }
        private static RegistryConfigurationProcessor Processor { get; set; }

        public static void Save()
        {
            ConfigurationHelper.Processor.SaveConfiguration(ConfigurationHelper.Current);
        }

        public static void AddValue(String section, String key, String value)
        {
            if (!ConfigurationHelper.Current.ContainsSection(section))
            {
                ConfigurationHelper.Current.AddSection(section);
            }

            if (!ConfigurationHelper.Current[section].ContainsKey(key))
            {
                ConfigurationHelper.Current[section].Add(key, value);
            }
        }
    }
}
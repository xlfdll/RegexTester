using System;
using System.IO;
using System.Text;

using RegexTester.Data;

namespace RegexTester.Helpers
{
    public static class TaskHelper
    {
        public static Object Match(Object argument)
        {
            return RegexHelper.Match(RegexStatus.Current.Input);
        }

        public static Object Split(Object argument)
        {
            return RegexHelper.Split(RegexStatus.Current.Input);
        }

        public static Object Replace(Object argument)
        {
            return RegexHelper.Replace(RegexStatus.Current.Input);
        }

        public static Object Measure(Object argument)
        {
            return RegexHelper.Measure(RegexStatus.Current.Input);
        }

        public static Object LoadJob(Object argument)
        {
            return FileHelper.LoadRegexInput(argument.ToString());
        }

        public static Object SaveJob(Object argument)
        {
            FileHelper.SaveRegexInput(argument.ToString(), RegexStatus.Current.Input);

            return null;
        }

        public static Object LoadText(Object argument)
        {
            // Use Encoding.Default to eliminate incorrect characters 
            return File.ReadAllText(argument.ToString(), Encoding.Default);
        }
    }
}
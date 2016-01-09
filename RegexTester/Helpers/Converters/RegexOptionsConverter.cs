using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;
using System.Windows.Markup;

using RegexTester.Data;

namespace RegexTester.Helpers.Converters
{
    public class RegexOptionsConverter : MarkupExtension, IValueConverter
    {
        public override Object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            RegexOptions targetRegexOptions = (RegexOptions)Enum.Parse(typeof(RegexOptions), parameter.ToString());

            // Use boolean operators explicitly
            return (RegexStatus.Current.Input.Options & targetRegexOptions) != RegexOptions.None;
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            RegexOptions targetRegexOptions = (RegexOptions)Enum.Parse(typeof(RegexOptions), parameter.ToString());

            if (System.Convert.ToBoolean(value))
            {
                return (RegexStatus.Current.Input.Options | targetRegexOptions);
            }
            else
            {
                return (RegexStatus.Current.Input.Options ^ targetRegexOptions);
            }
        }
    }
}
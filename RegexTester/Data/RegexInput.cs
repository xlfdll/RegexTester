using System;
using System.Text.RegularExpressions;

using Xlfdll.Core;

namespace RegexTester.Data
{
    public class RegexInput : ObservableObject
    {
        public RegexInput()
            : this(String.Empty, String.Empty, String.Empty, RegexOptions.None) { }

        public RegexInput(String regexPattern, String replacePattern, String text, RegexOptions options)
        {
            this.RegexPattern = regexPattern;
            this.ReplacePattern = replacePattern;
            this.Text = text;
            this.Options = options;
        }

        private String _regexPattern;
        private String _replacePattern;
        private String _text;
        private RegexOptions _options;

        public String RegexPattern
        {
            get
            {
                return _regexPattern;
            }
            set
            {
                _regexPattern = value;

                OnPropertyChanged(nameof(this.RegexPattern));
            }
        }
        public String ReplacePattern
        {
            get
            {
                return _replacePattern;
            }
            set
            {
                _replacePattern = value;

                OnPropertyChanged(nameof(this.ReplacePattern));
            }
        }
        public String Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;

                OnPropertyChanged(nameof(this.Text));
            }
        }
        public RegexOptions Options
        {
            get
            {
                return _options;
            }
            set
            {
                _options = value;

                OnPropertyChanged(nameof(this.Options));
            }
        }

        public RegexInput Clone()
        {
            return new RegexInput(this._regexPattern, this._replacePattern, this._text, this._options);
        }
    }
}
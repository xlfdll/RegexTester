using System;
using System.Text.RegularExpressions;

namespace RegexTester
{
    internal class RegexInput
    {
        internal RegexInput(String contents, String regexPattern, String replacePattern, RegexOptions options)
        {
            _contents = contents;
            _regexPattern = String.Copy(regexPattern);
            _replacePattern = String.Copy(replacePattern);
            _options = options;
        }

        private String _contents;
        private String _regexPattern;
        private String _replacePattern;
        private RegexOptions _options;

        internal String Contents
        {
            get { return _contents; }
        }

        internal String RegexPattern
        {
            get { return _regexPattern; }
        }

        internal String ReplacePattern
        {
            get { return _replacePattern; }
        }

        internal RegexOptions Options
        {
            get { return _options; }
        }
    }
}
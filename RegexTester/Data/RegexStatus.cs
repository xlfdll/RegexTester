using System;
using System.Collections.Generic;
using System.IO;

using Xlfdll.Core;

using RegexTester.Helpers;

namespace RegexTester.Data
{
    public class RegexStatus : ObservableObject
    {
        public RegexStatus()
        {
            this.Input = new RegexInput();
            this.Result = new RegexResult();

            this.Update(String.Empty);

            RegexStatus.Current = this;
        }

        #region Main Data

        private RegexInput _input;
        private RegexResult _result;

        public RegexInput Input
        {
            get { return _input; }
            set { this.SetField<RegexInput>(ref _input, value); }
        }
        public RegexResult Result
        {
            get { return _result; }
            set { this.SetField<RegexResult>(ref _result, value); }
        }

        #endregion

        #region History Data

        public IReadOnlyCollection<String> RecentRegexPatterns
        {
            get { return ApplicationHelper.Settings.History.RecentRegexPatterns; }
        }
        public IReadOnlyCollection<String> RecentReplacePatterns
        {
            get { return ApplicationHelper.Settings.History.RecentReplacePatterns; }
        }

        #endregion

        #region Status Data

        public Boolean IsInputModified
        {
            get
            {
                return !(_input.RegexPattern.Equals(originalInput.RegexPattern)
                && _input.ReplacePattern.Equals(originalInput.ReplacePattern)
                && _input.Text.Equals(originalInput.Text)
                && _input.Options.Equals(originalInput.Options));
            }
        }
        public String InputFilePath
        {
            get { return inputFilePath; }
        }

        private RegexInput originalInput;
        private String inputFilePath;

        public void Update(String path)
        {
            originalInput = _input.Clone();
            inputFilePath = path;

            ApplicationHelper.MainWindow.Title =
                (!String.IsNullOrEmpty(path) ? Path.GetFileNameWithoutExtension(path) + " - " : String.Empty)
                + ApplicationHelper.Metadata.AssemblyTitle;
        }

        #endregion

        public static RegexStatus Current { get; private set; }
    }
}
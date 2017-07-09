﻿using System;
using System.Collections.Generic;
using System.IO;

using Xlfdll.Core;

using RegexTester.Helpers;

namespace RegexTester.Data
{
	public class AppState : ObservableObject
	{
		public AppState()
		{
			this.Input = new RegexInput();
			this.Result = new RegexResult();

			this.Update(String.Empty);

			AppState.Current = this;
		}

		#region Main Data

		private RegexInput _input;
		private RegexResult _result;

		public RegexInput Input
		{
			get => _input;
			set => this.SetField(ref _input, value);
		}
		public RegexResult Result
		{
			get => _result;
			set => this.SetField(ref _result, value);
		}

		#endregion

		#region History Data

		public IReadOnlyCollection<String> RecentRegexPatterns
			=> ApplicationHelper.Settings.History.RecentRegexPatterns;
		public IReadOnlyCollection<String> RecentReplacePatterns
			=> ApplicationHelper.Settings.History.RecentReplacePatterns;

		#endregion

		#region Status Data

		public Boolean IsInputModified
			=> !(_input.RegexPattern.Equals(originalInput.RegexPattern)
			&& _input.ReplacePattern.Equals(originalInput.ReplacePattern)
			&& _input.Text.Equals(originalInput.Text)
			&& _input.Options.Equals(originalInput.Options));
		public String InputFilePath => inputFilePath;

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

		public static AppState Current { get; private set; }
	}
}
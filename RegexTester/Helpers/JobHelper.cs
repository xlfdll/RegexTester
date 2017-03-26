using System;
using System.IO;
using System.Text;

using Xlfdll.Windows.Presentation.Dialogs;

using RegexTester.Data;
using RegexTester.Windows;

namespace RegexTester.Helpers
{
	public static class JobHelper
	{
		public static void LoadRegexJob(String path)
		{
			TaskWindow taskWindow = new TaskWindow
			(
				delegate (Object argument)
				{
					return RegexHelper.Match(RegexState.Current.Input);
				},
				path
			)
			{
				Owner = ApplicationHelper.MainWindow
			};

			taskWindow.ShowDialog();

			if (taskWindow.Exception == null)
			{
				RegexInput regexInput = taskWindow.Result as RegexInput;

				if (regexInput != null)
				{
					RegexState.Current.Input = regexInput;
					RegexState.Current.Update(path);
				}
			}
			else
			{
				ExceptionMessageBox.Show(ApplicationHelper.MainWindow, ApplicationHelper.Metadata.AssemblyTitle, "Invalid job file format.", taskWindow.Exception.InnerException);
			}
		}

		public static void SaveRegexJob(String path)
		{
			TaskWindow taskWindow = new TaskWindow
			(
				delegate (Object argument)
				{
					FileHelper.SaveRegexInput(argument.ToString(), RegexState.Current.Input);

					return null;
				},
				path
			)
			{
				Owner = ApplicationHelper.MainWindow
			};

			taskWindow.ShowDialog();

			if (taskWindow.Exception == null)
			{
				RegexState.Current.Update(path);
			}
			else
			{
				ExceptionMessageBox.Show(ApplicationHelper.MainWindow, ApplicationHelper.Metadata.AssemblyTitle, "Unexpected exception happened.", taskWindow.Exception.InnerException);
			}
		}

		public static void LoadTextDocument(String path)
		{
			TaskWindow taskWindow = new TaskWindow
			(
				delegate (Object argument)
				{
					// Use Encoding.Default to eliminate incorrect characters 
					return File.ReadAllText(argument.ToString(), Encoding.Default);
				},
				path
			)
			{
				Owner = ApplicationHelper.MainWindow
			};

			taskWindow.ShowDialog();

			if (taskWindow.Exception == null)
			{
				String text = taskWindow.Result as String;

				if (text != null)
				{
					RegexState.Current.Input.Text = text;
				}
			}
			else
			{
				ExceptionMessageBox.Show(ApplicationHelper.MainWindow, ApplicationHelper.Metadata.AssemblyTitle, "Invalid job file format.", taskWindow.Exception.InnerException);
			}
		}
	}
}
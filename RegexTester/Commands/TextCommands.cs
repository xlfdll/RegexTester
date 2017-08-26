using System;
using System.Reflection;
using System.Windows;

using Xlfdll.Windows.Presentation;

using RegexTester.Helpers;

namespace RegexTester.Commands
{
	public static class TextCommands
	{
		static TextCommands()
		{
			TextCommands.LoadTextCommand = new RelayCommand<String>
			(
				delegate (String argument)
				{
					Type t = Type.GetType($"RegexTester.Windows.Text.LoadFrom{argument}TextWindow, {Assembly.GetExecutingAssembly().FullName}");

					Window patternWindow = Activator.CreateInstance(t) as Window;

					patternWindow.Owner = ApplicationHelper.MainWindow;
					patternWindow.ShowDialog();
				}
			);
		}

		public static RelayCommand<String> LoadTextCommand { get; }
	}
}
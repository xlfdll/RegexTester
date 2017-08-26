using System;
using System.Net;
using System.Text;
using System.Windows;

using Xlfdll.Windows.Presentation.Dialogs;

using RegexTester.Data;

namespace RegexTester.Windows.Text
{
	/// <summary>
	/// LoadFromWebTextWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class LoadFromWebTextWindow : Window
	{
		public LoadFromWebTextWindow()
		{
			InitializeComponent();
		}

		private void LoadFromWebTextWindow_Loaded(object sender, RoutedEventArgs e)
		{
			EncodingComboBox.ItemsSource = Encoding.GetEncodings();
			EncodingComboBox.SelectedIndex = (EncodingComboBox.ItemsSource as EncodingInfo[]).Length - 1;
		}

		private void LoadButton_Click(object sender, RoutedEventArgs e)
		{
			this.IsEnabled = false;

			WebClient webClient = new WebClient();

			webClient.DownloadStringCompleted += WebClient_DownloadStringCompleted;

			try
			{
				Uri uri = new Uri(URLTextBox.Text);

				webClient.DownloadStringAsync(uri);
			}
			catch (UriFormatException uriFormatEx)
			{
				ExceptionMessageBox.Show(this.Title, "The format of the URL " +
					$"{Environment.NewLine}{Environment.NewLine}{URLTextBox.Text}{Environment.NewLine}{Environment.NewLine}" +
					" is not correct.", uriFormatEx);
			}
			catch (Exception ex)
			{
				ExceptionMessageBox.Show(this.Title, "The following error occurred:", ex);
			}
			finally
			{
				webClient.Dispose();

				this.IsEnabled = true;
			}
		}

		private void WebClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				AppState.Current.Input.Text = e.Result;

				this.Close();
			}
			else
			{
				ExceptionMessageBox.Show(this.Title, $"The following error occurred when retrieving the content from {URLTextBox.Text}:", e.Error);
			}
		}
	}
}
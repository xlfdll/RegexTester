using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

using Xlfdll.Windows.Presentation;

namespace RegexTester.Windows
{
    /// <summary>
    /// TaskWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class TaskWindow : Window
    {
        private TaskWindow()
        {
            InitializeComponent();
        }

        public TaskWindow(Func<Object, Object> function, Object argument)
            : this()
        {
            this.BackgroundTask = new Task<Object>(function, argument);
        }

        private void TaskWindow_Loaded(object sender, RoutedEventArgs e)
        {
            WindowFunctions.DisableControlBox(this);

            this.TaskStateTimer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromMilliseconds(10)
            };
            this.TaskStateTimer.Tick += TaskStateTimer_Tick;

            this.BackgroundTask.Start();
            this.TaskStateTimer.Start();
        }

        private void TaskStateTimer_Tick(object sender, EventArgs e)
        {
            if (this.BackgroundTask.IsCompleted)
            {
                this.TaskStateTimer.Stop();

                if (this.BackgroundTask.IsFaulted)
                {
                    // If faulted, no results for sure
                    this.Exception = this.BackgroundTask.Exception;
                }
                else
                {
                    this.Result = this.BackgroundTask.Result;
                }

                this.BackgroundTask.Dispose();

                this.Close();
            }
        }

        public Object Result { get; private set; }
        public AggregateException Exception { get; private set; }

        private Task<Object> BackgroundTask { get; set; }
        private DispatcherTimer TaskStateTimer { get; set; }
    }
}
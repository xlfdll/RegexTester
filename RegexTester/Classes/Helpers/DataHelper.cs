using System;
using System.IO;

using RegexTester.Forms;
using RegexTester.Properties;

namespace RegexTester
{
    internal static class DataHelper
    {
        #region Report Methods

        internal static void ImportReport(String fileName)
        {
            if (File.Exists(fileName))
            {
                FormHelper.MainFormInstance.Reset();

                FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork += WorkHelper.ImportBackgroundWorker_DoWork;
                FormHelper.ProgressFormInstance.MainBackgroundWorker.ProgressChanged += WorkHelper.ImportBackgroundWorker_ProgressChanged;
                FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted += WorkHelper.ImportBackgroundWorker_RunWorkerCompleted;

                FormHelper.ProgressFormInstance.ShowAndWork(fileName);
            }
        }

        internal static void ExportReport(String fileName)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork += WorkHelper.ExportBackgroundWorker_DoWork;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.ProgressChanged += WorkHelper.ExportBackgroundWorker_ProgressChanged;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted += WorkHelper.ExportBackgroundWorker_RunWorkerCompleted;

            FormHelper.ProgressFormInstance.ShowAndWork(fileName);
        }

        #endregion

        #region Data Status

        private static SearchStatus _status;

        internal static SearchStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion
    }
}
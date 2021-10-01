using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N3
{
    /// <summary>
    /// チェックボックスVeiw
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new CheckBoxView();
            var pre = new CheckBoxPresenter(view);
            Application.Run(view);
        }

        /// <summary>
        /// エラーメッセージ表示
        /// </summary>
        /// <param name="message">メッセージ</param>
        public static void ShowErrMessage(string message)
        {
            MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

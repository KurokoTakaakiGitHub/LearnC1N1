using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N2
{
    /// <summary>
    /// プログラム
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public　static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new TextBoxLabelView();
            var presenter = new TextBoxLabelPresenter(view);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N7
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new BirthDateCalc();
            var pre = new BirthDateCalcPresenter(view);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N4
{
    /// <summary>
    /// ラジオボタン
    /// </summary>
    public　static class Program
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

            var view = new RadioButtonView();
            var pre = new RadioButtonPresenter(view);

            Application.Run(view);
        }
    }
}

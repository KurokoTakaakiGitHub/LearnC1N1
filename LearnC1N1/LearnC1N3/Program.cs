using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N3
{
    /// <summary>
    /// �`�F�b�N�{�b�N�XVeiw
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
        /// �G���[���b�Z�[�W�\��
        /// </summary>
        /// <param name="message">���b�Z�[�W</param>
        public static void ShowErrMessage(string message)
        {
            MessageBox.Show(message, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

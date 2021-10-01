using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N6
{
    /// <summary>
    /// ���X�g�{�b�N�X�Q
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

            var view = new ListBoxView2();
            var pre = new ListBoxPresenter2(view);

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

using System;
using System.Windows.Forms;
using LearnC1N1.Properties;

namespace LearnC1N1
{
    /// <summary>
    /// 年齢計算View
    /// </summary>
    public partial class AgeCalcView : Form, IAgeCalcView
    {
        /// <summary>OKボタン</summary>
        public Action<string, string> OkButtonAction { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgeCalcView"/> class.
        /// </summary>
        public AgeCalcView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// OKボタンクリック
        /// </summary>
        /// <param name="sender">呼出し元</param>
        /// <param name="e">パラメータ</param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.OkButtonAction(this.TextBoxName.Text, this.DateTimePickerBirthDate.Value.Date.ToShortDateString());
        }

        /// <summary>
        /// 警告メッセージ表示
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void ShowWarningMessage(string message)
        {
            MessageBox.Show(this, message, Resources.String_Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 確認メッセージ取得
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void ShowInfoMessage(string message)
        {
            MessageBox.Show(this, message, Resources.String_Confirmation, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

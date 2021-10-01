using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N2
{
    /// <summary>
    /// テキストボックス＆ラベル
    /// </summary>
    public partial class TextBoxLabelView : Form, ITextBoxLabelView
    {
        /// <summary>入力ボタン</summary>
        public Action<string> InputButtonAction { get; set; }

        /// <summary>Inputラベル有効</summary>
        public bool IsEnabledInputLabel
        {
            get { return this.IsEnabledInputLabel; }
            set { this.LabelText.Enabled = value; }
        }

        /// <summary>InputText</summary>
        public string TextInputLabel
        {
            get { return this.TextInputLabel; }
            set { this.LabelText.Text = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxLabelView"/> class.
        /// </summary>
        public TextBoxLabelView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 入力ボタンクリック
        /// </summary>
        /// <param name="sender">呼出し元</param>
        /// <param name="e">パラメータ</param>
        private void ButtonInput_Click(object sender, EventArgs e)
        {
            this.InputButtonAction(this.TextBoxInput.Text);
        }

        /// <summary>
        /// 警告メッセージ表示
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void ShowWarningMessage(string message)
        {
            MessageBox.Show(this, message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

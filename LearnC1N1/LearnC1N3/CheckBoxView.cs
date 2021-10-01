using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N3
{
    /// <summary>
    /// チェックボックスVeiw
    /// </summary>
    public partial class CheckBoxView : Form, ICheckBoxView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxView"/> class.
        /// </summary>
        public CheckBoxView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 決定ボタン
        /// </summary>
        public Action<bool, bool, bool> DecisionButtonAction { get; set; }

        /// <summary>
        /// 決定ボタンクリック
        /// </summary>
        private void ButtonDecision_Click(object sender, EventArgs e)
        {
            this.DecisionButtonAction(this.CheckBoxA.Checked, this.CheckBoxB.Checked, this.CheckBoxC.Checked);
        }

        /// <summary>
        /// 確認メッセージ取得
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void ShowInfoMessage(string message)
        {
            MessageBox.Show(this, message, "計算結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

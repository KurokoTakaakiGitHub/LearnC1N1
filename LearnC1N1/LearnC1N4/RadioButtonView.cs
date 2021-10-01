using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N4
{
    /// <summary>
    /// ラジオボタンView
    /// </summary>
    public partial class RadioButtonView : Form, IRadioButtonView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButtonView"/> class.
        /// </summary>
        public RadioButtonView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 背景色設定ボタン
        /// </summary>
        public Action<bool, bool, bool> SetBackColorButtonAction { get; set; }

        /// <summary>
        /// View背景色
        /// </summary>
        public Color ViewBackColor
        {
            get { return this.ViewBackColor; }
            set { this.BackColor = value; }
        }

        /// <summary>
        /// 背景色設定ボタンクリック
        /// </summary>
        /// <param name="sender">呼出し元</param>
        /// <param name="e">パラメータ</param>
        private void ButtonSetBackColor_Click(object sender, EventArgs e)
        {
            this.SetBackColorButtonAction(this.RadioButtonColorRed.Checked, this.RadioButtonColorBlue.Checked, this.RadioButtonColorGreen.Checked);
        }
    }
}

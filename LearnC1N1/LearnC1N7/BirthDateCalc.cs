using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N7
{
    /// <summary>
    /// 誕生日計算View
    /// </summary>
    public partial class BirthDateCalc : Form , IBirthDateCalc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BirthDateCalc"/> class.
        /// </summary>
        public BirthDateCalc()
        {
            this.InitializeComponent();
        }

        /// <summary>誕生日計算</summary>
        public Action<string> BirthDateCalcAction { get; set; }


        /// <summary>メッセージ</summary>

        public string Message
        {
            set
            {
                this.label2.Text = value;
            }
        }

        /// <summary>
        /// Okボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.BirthDateCalcAction(DateTimePickerBirthDate.Value.ToShortDateString());
        }
    }
}

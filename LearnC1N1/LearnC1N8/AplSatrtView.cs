using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N8
{
    /// <summary>
    /// アプリ起動View
    /// </summary>
    public partial class AplStartView : Form, IAplStartView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AplStartView"/> class.
        /// </summary>
        public AplStartView()
        {
            this.InitializeComponent();
        }

        /// <summary>メモ帳起動</summary>
        public Action StartNotepatProcessAction { get; set; }

        /// <summary>ペイント起動</summary>
        public Action StartPaintProcessAction { get; set; }

        /// <summary>
        /// メモ帳起動ボタン
        /// </summary>
        /// <param name="sender">呼出し元</param>
        /// <param name="e">パラメータ</param>
        private void ButtonStartMemo_Click(object sender, EventArgs e)
        {
            this.StartNotepatProcessAction();
        }

        /// <summary>
        /// ペイント起動ボタン
        /// </summary>
        /// <param name="sender">呼出し元</param>
        /// <param name="e">パラメータ</param>
        private void ButtonStartPaint_Click(object sender, EventArgs e)
        {
            this.StartPaintProcessAction();
        }
    }
}

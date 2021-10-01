using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N5
{
    /// <summary>
    /// リストボックスView
    /// </summary>
    public partial class ListBoxView : Form, IListBoxView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxView"/> class.
        /// </summary>
        public ListBoxView()
        {
            this.InitializeComponent();
        }

        /// <summary>リストボックスアイテム追加</summary>
        public Action SetListBoxItemsAction { get; set; }

        /// <summary>Okボタン</summary>
        public Action<object> OkButtonAction { get; set; }

        /// <summary>
        /// 持ち物リスト
        /// </summary>
        public BelongingsTypeObject[] BelongingsList
        {
            get
            {
                return this.BelongingsList;
            }

            set
            {
                this.ListBoxBelongings.Items.Clear();
                this.ListBoxBelongings.Items.AddRange(value);
            }
        }

        /// <summary>
        /// 読込時
        /// </summary>
        /// <param name="sender">呼出し元</param>
        /// <param name="e">パラメータ</param>
        private void ListBoxView_Load(object sender, EventArgs e)
        {
            this.SetListBoxItemsAction();
        }

        /// <summary>
        /// Okボタン
        /// </summary>
        /// <param name="sender">読込</param>
        /// <param name="e">パラメータ</param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.OkButtonAction(this.ListBoxBelongings.SelectedItem);
        }

        /// <summary>
        /// 確認メッセージ取得
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void ShowInfoMessage(string message)
        {
            MessageBox.Show(this, message, "持ち物リスト", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 警告メッセージ取得
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void ShowWarningMessage(string message)
        {
            MessageBox.Show(this, message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N6X
{
    /// <summary>
    /// リストボックス2
    /// </summary>
    public partial class ListBoxView2 : Form, IListBoxView2
    {
        /// <summary>買い物リスト初期化</summary>
        public Action ClearShoppingListAction { get; set; }

        /// <summary>買い物リスト追加</summary>
        public Action<string> AddShoppingListItemButtunAction { get; set; }

        /// <summary>買い物リスト削除</summary>
        public Action<object> DeleteShoppingListItemButtunAction { get; set; }

        /// <summary>買い物リスト</summary>
        public List<ShoppingListItem> ShoppingList
        {
            get
            {
                return this.shoppingList;
            }

            set
            {
                this.ListBoxShoppingList.Items.Clear();
                if (value is null)
                {
                    return;
                }

                this.ListBoxShoppingList.Items.AddRange(value.ToArray());
            }
        }

        /// <summary>買い物リスト</summary>
        private readonly List<ShoppingListItem> shoppingList = new();

        /// <summary>追加する買い物</summary>
        public ShoppingListItem AddShoppingListItem
        {
            set
            {
                this.ListBoxShoppingList.Items.Add(value);
                this.shoppingList.Add(value);
            }
        }

        /// <summary>削除する買い物</summary>
        public ShoppingListItem DeleteShoppingListItem
        {
            set
            {
                this.ListBoxShoppingList.Items.Remove(value);
                this.shoppingList.Remove(value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxView2"/> class.
        /// </summary>
        public ListBoxView2()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 読込
        /// </summary>
        /// <param name="sender">呼出し元</param>
        /// <param name="e">パラメータ</param>
        private void ListBoxView2_Load(object sender, EventArgs e)
        {
            this.ListBoxShoppingList.Items.Clear();
        }

        /// <summary>
        /// 買い物リスト追加ボタン
        /// </summary>
        /// <param name="sender">呼出し元</param>
        /// <param name="e">パラメータ</param>
        private void ButtonAddShoppingList_Click(object sender, EventArgs e)
        {
            this.AddShoppingListItemButtunAction(this.TextBoxShoppingItem.Text);
        }

        /// <summary>
        /// 買い物リスト削除ボタン
        /// </summary>
        /// <param name="sender">呼出し元</param>
        /// <param name="e">パレメータ</param>
        private void ButtonDeleteShoppingList_Click(object sender, EventArgs e)
        {
            this.DeleteShoppingListItemButtunAction(this.ListBoxShoppingList.SelectedItem);
        }

        /// <summary>
        /// 確認Messageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="messageBoxButtons">ボタン種類</param>
        /// <returns>選択した結果</returns>
        public DialogResult ShowInfoMessage(string message, MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(this, message, "確認", messageBoxButtons, MessageBoxIcon.Information);
        }

        /// <summary>
        /// ワーニングMessageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void ShowWarningMessage(string message)
        {
            MessageBox.Show(this, message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

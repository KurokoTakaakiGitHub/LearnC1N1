using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC1N6
{
    /// <summary>
    /// リストボックス２：インタフェース
    /// </summary>
    public interface IListBoxView2
    {
        /// <summary>買い物リスト初期化</summary>
        public Action ClearShoppingListAction { get; set; }

        /// <summary>買い物リスト追加ボタン</summary>
        public Action<string> AddShoppingListItemButtunAction { get; set; }

        /// <summary>買い物リスト削除ボタン</summary>
        public Action<object> DeleteShoppingListItemButtunAction { get; set; }

        /// <summary>買い物リスト</summary>
        public List<ShoppingListItem> ShoppingList { get; set; }

        /// <summary>買い物リストに追加する項目</summary>
        public ShoppingListItem AddShoppingListItem { set; }

        /// <summary>買い物リストから削除する項目</summary>
        public ShoppingListItem DeleteShoppingListItem { set; }

        /// <summary>
        /// Viewを表示する
        /// </summary>
        void Show();

        /// <summary>
        /// 確認Messageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="messageBoxButtons">ボタン種類</param>
        /// <returns>選択した結果</returns>
        DialogResult ShowInfoMessage(string message, MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK);

        /// <summary>
        /// ワーニングMessageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        void ShowWarningMessage(string message);
    }
}

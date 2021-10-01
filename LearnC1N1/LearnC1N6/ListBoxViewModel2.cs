using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N6
{
    /// <summary>
    /// リストボックス・モデル
    /// </summary>
    public class ListBoxViewModel2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxViewModel2"/> class.
        /// </summary>
        public ListBoxViewModel2()
        {
        }

        /// <summary>
        /// 買い物リストに追加する項目を取得
        /// </summary>
        /// <param name="inputItem">入力した項目</param>
        /// <returns>買い物リストに追加する項目</returns>
        public static ShoppingListItem GetAddShoppingListItem(string inputItem)
        {
            return new ShoppingListItem(inputItem);
        }

        /// <summary>
        ///  買い物リストに同じ項目がないか
        /// </summary>
        /// <param name="shoppingListItems">買い物リスト</param>
        /// <param name="item">項目</param>
        /// <returns>true;存在する false:存在しない</returns>
        public static bool ExistShoppingListItem(IEnumerable<ShoppingListItem> shoppingListItems, ShoppingListItem item)
        {
            if (shoppingListItems is null)
            {
                return false;
            }

            return shoppingListItems.Any(x => x.Equals(item));
        }

        /// <summary>
        /// 買い物リストから削除する項目を取得
        /// </summary>
        /// <param name="selectedItme">選択した項目</param>
        /// <returns>削除する項目</returns>
        public static ShoppingListItem GetDeleteShoppingListItem(object selectedItme)
        {
            if (selectedItme is not ShoppingListItem shoppingListItem)
            {
                throw new ArgumentNullException(nameof(selectedItme));
            }

            return shoppingListItem;
        }
    }
}
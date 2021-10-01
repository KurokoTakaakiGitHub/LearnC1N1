using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N6X
{
    /// <summary>
    /// リストボックス・モデル
    /// </summary>
    public class ListBoxViewModel2
    {
        private readonly ShoppingListAppService shoppingListAppService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxViewModel2"/> class.
        /// </summary>
        public ListBoxViewModel2()
        {
            this.shoppingListAppService = new ShoppingListAppService(new InMemoryShoppingListRepository());
        }

        /// <summary>
        /// 買い物リストの項目を登録する
        /// </summary>
        /// <param name="inputItem">入力した項目</param>
        /// <returns>true:正常 false:異常</returns>
        public bool CreateShoppingListItem(string inputItem, out ShoppingListItem shoppingListItem)
        {
            shoppingListItem = new ShoppingListItem(inputItem);
            return shoppingListAppService.CreateItemShoppingList(shoppingListItem);
        }

        /// <summary>
        /// 買い物リストから項目を削除する
        /// </summary>
        /// <param name="selectedItme">選択した項目</param>
        /// <returns>削除する項目</returns>
        public bool DeleteShoppingListItem(object selectedItme, out ShoppingListItem shoppingListItem)
        {
            shoppingListItem = selectedItme as ShoppingListItem;

            if (shoppingListItem is null)
            {
                throw new ArgumentNullException(nameof(selectedItme));
            }

            return shoppingListAppService.DeleteItemShoppingList(shoppingListItem);
        }
    }
}
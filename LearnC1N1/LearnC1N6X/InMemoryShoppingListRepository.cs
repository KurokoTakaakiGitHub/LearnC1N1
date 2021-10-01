using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N6X
{
    /// <summary>
    /// 買い物リスト・リポジトリ
    /// </summary>
    public class InMemoryShoppingListRepository : IShoppingListRepository
    {
        /// <summary>買い物リスト</summary>
        private readonly Dictionary<string, ShoppingListItem> shoppingList = new();

        /// <summary>
        /// 登録
        /// </summary>
        /// <param name="shoppingListItem">買い物リスト項目</param>
        /// <returns>true:正常　false:異常（登録データあり）</returns>
        public bool Register(ShoppingListItem shoppingListItem)
        {
            if (this.shoppingList.TryGetValue(shoppingListItem.Value, out var _))
            {
                return false;
            }

            this.shoppingList.Add(shoppingListItem.Value, shoppingListItem);

            return true;
        }

        /// <summary>
        /// 削除
        /// </summary>
        /// <param name="shoppingListItem">買い物リスト項目</param>
        /// <returns>true:正常　false:異常（削除データない）</returns>
        public bool Delete(ShoppingListItem shoppingListItem)
        {
            if (!this.shoppingList.TryGetValue(shoppingListItem.Value, out var _))
            {
                return false;
            }

            this.shoppingList.Remove(shoppingListItem.Value);

            return true;
        }
    }
}

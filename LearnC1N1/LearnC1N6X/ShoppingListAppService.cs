using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N6X
{
    /// <summary>
    /// 買い物リスト・アプリケーションサービス
    /// </summary>
    public class ShoppingListAppService
    {
        /// <summary>リポジトリ</summary>
        private readonly IShoppingListRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingListAppService"/> class.
        /// </summary>
        /// <param name="shoppingListRepository">リポジトリ</param>
        public ShoppingListAppService(IShoppingListRepository shoppingListRepository)
        {
            this.repository = shoppingListRepository;
        }

        /// <summary>
        /// 買い物リストに項目を追加する
        /// </summary>
        /// <param name="shoppingListItem"></param>
        /// <returns>true:正常　false:異常（登録データあり）</returns>
        public bool CreateItemShoppingList(ShoppingListItem shoppingListItem)
        {
           return repository.Register(shoppingListItem);
        }

        /// <summary>
        /// 買い物リストから項目を削除する
        /// </summary>
        /// <param name="shoppingListItem"></param>
        /// <returns>true:正常　false:異常（削除データなし）</returns>
        public bool DeleteItemShoppingList(ShoppingListItem shoppingListItem)
        {
            return repository.Delete(shoppingListItem);
        }
    }
}

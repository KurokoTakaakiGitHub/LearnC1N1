using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N6X
{
    /// <summary>
    /// 買い物リスト・リポジトリ・インタフェース
    /// </summary>
    public interface IShoppingListRepository
    {

        /// <summary>登録</summary>
        public bool Register(ShoppingListItem shoppingListItem);

        /// <summary>削除</summary>
        public bool Delete(ShoppingListItem shoppingListItem);
    }
}

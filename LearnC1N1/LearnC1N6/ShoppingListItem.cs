using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N6
{
    /// <summary>
    /// 買い物リスト項目
    /// </summary>
    public class ShoppingListItem : IEquatable<ShoppingListItem>
    {
        /// <summary>値</summary>
        public string Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingListItem"/> class.
        /// </summary>
        /// <param name="shoppingListItem">買い物リスト項目</param>
        public ShoppingListItem(string shoppingListItem)
        {
            if (string.IsNullOrEmpty(shoppingListItem))
            {
                throw new ArgumentOutOfRangeException(nameof(shoppingListItem));
            }

            this.Value = shoppingListItem;
        }

        /// <summary>
        /// 文字列変換
        /// </summary>
        /// <returns>文字列</returns>
        public override string ToString()
        {
            return this.Value;
        }

        /// <summary>
        /// 比較
        /// </summary>
        /// <param name="other">比較先</param>
        /// <returns>true:一致 false:不一致</returns>
        public bool Equals(ShoppingListItem other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Equals(this.Value, other.Value);
        }

        /// <summary>
        /// 比較・オーバーライド
        /// </summary>
        /// <param name="obj">比較先</param>
        /// <returns>true:一致 false:不一致</returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals((ShoppingListItem)obj);
        }

        /// <summary>
        /// HashCode・オーバーライド
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Value);
        }
    }
}

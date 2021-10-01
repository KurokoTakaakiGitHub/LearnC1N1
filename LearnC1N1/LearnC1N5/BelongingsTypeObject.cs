using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N5
{
    /// <summary>
    /// 持ち物種類・オブジェクト
    /// </summary>
    public class BelongingsTypeObject
    {
        /// <summary>値</summary>
        public BelongingsType Value { get; }

        /// <summary>表示文字列</summary>
        public string DisplayName { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BelongingsTypeObject"/> class.
        /// </summary>
        /// <param name="belongingsType">持ち物</param>
        public BelongingsTypeObject(BelongingsType belongingsType)
        {
            this.Value = belongingsType;
            this.DisplayName = BelongingsTypeExt.DisplayName(belongingsType);
        }

        /// <summary>
        /// 文字列
        /// </summary>
        /// <returns>表示文字列/returns>
        public override string ToString()
        {
            return this.DisplayName;
        }
    }
}

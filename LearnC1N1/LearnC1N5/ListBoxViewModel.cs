using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N5
{
    /// <summary>
    /// リストボックス・モデル
    /// </summary>
    public class ListBoxViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxViewModel"/> class.
        /// </summary>
        public ListBoxViewModel()
        {
        }

        /// <summary>
        /// 持ち物リストを取得
        /// </summary>
        /// <returns>持ち物リスト</returns>
        public static BelongingsTypeObject[] GetBelongingsList()
        {
            var list = new List<BelongingsTypeObject>();

            foreach (BelongingsType belongingsType in Enum.GetValues(typeof(BelongingsType)))
            {
                list.Add(new BelongingsTypeObject(belongingsType));
            }

            return list.ToArray();
        }

        /// <summary>
        /// 選択した持ち物の表示文字列を取得
        /// </summary>
        /// <param name="selectedItme">選択した持ち物</param>
        /// <returns>持ち物の表示文字列</returns>
        public static string GetSelectedBelongingsStr(object selectedItme)
        {
            if (selectedItme is not BelongingsTypeObject belongingsTypeObject)
            {
                throw new ArgumentNullException(nameof(selectedItme));
            }

            return belongingsTypeObject.DisplayName;
        }
    }
}
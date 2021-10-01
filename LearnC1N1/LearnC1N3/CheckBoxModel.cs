using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N3
{
    /// <summary>
    /// チェックボックス・モデル
    /// </summary>
    public class CheckBoxModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxModel"/> class.
        /// </summary>
        public CheckBoxModel()
        {
        }

        /// <summary>
        /// 商品の金額を計算する
        /// </summary>
        /// <param name="calcA">チェックボックスA</param>
        /// <param name="calcB">チェックボックスB</param>
        /// <param name="calcC">チェックボックスC</param>
        /// <returns>合計金額メッセージ</returns>
        public static string CalcItemPrice(bool calcA, bool calcB, bool calcC)
        {
            try
            {
                int kinGk = 0;

                if (calcA)
                {
                    kinGk += 500;
                }

                if (calcB)
                {
                    kinGk += 600;
                }

                if (calcC)
                {
                    kinGk += 700;
                }

                return $"合計金額は {kinGk} 円です。";
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
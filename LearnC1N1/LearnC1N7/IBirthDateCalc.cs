using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N7
{
    /// <summary>
    /// 誕生日計算・インタフェース
    /// </summary>
    public interface IBirthDateCalc
    {
        /// <summary>誕生日計算</summary>
        public Action<string> BirthDateCalcAction { get; set; }

        /// <summary>メッセージ</summary>
        public string Message { set; }

        /// <summary>View表示</summary>
        public void Show();
    }
}

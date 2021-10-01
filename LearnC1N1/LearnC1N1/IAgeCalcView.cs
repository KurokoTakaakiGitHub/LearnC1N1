using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N1
{
    /// <summary>
    /// 年齢計算View/インタフェース
    /// </summary>
    public interface IAgeCalcView
    {
        /// <summary>OKボタン</summary>
        Action<string, string> OkButtonAction { get; set; }

        /// <summary>
        /// Viewを表示する
        /// </summary>
        void Show();

        /// <summary>
        /// ワーニングMessageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        void ShowWarningMessage(string message);

        /// <summary>
        /// 確認Messageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        void ShowInfoMessage(string message);
    }
}

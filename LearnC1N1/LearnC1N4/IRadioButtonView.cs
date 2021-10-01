using System;
using System.Drawing;

namespace LearnC1N4
{
    /// <summary>
    /// ラジオボタンView/インタフェース
    /// </summary>
    public　interface IRadioButtonView
    {
        /// <summary>
        /// Viewを表示する
        /// </summary>
        void Show();

        /// <summary>
        /// 背景色設定ボタン
        /// </summary>
        Action<bool, bool, bool> SetBackColorButtonAction { get; set; }

        /// <summary>
        /// View背景章
        /// </summary>
        Color ViewBackColor { get; set; }
    }
}

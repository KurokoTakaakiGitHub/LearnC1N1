using System;
using System.Collections.Generic;
using System.Drawing;

namespace LearnC1N5
{
    /// <summary>
    /// リストボックスView/インタフェース
    /// </summary>
    public　interface IListBoxView
    {
        /// <summary>
        /// Viewを表示する
        /// </summary>
        void Show();

        /// <summary>
        /// リストボックス設定
        /// </summary>
        Action SetListBoxItemsAction { get; set; }

        /// <summary>
        /// OKボタン
        /// </summary>
        Action<object> OkButtonAction { get; set; }

        /// <summary>
        /// 持ち物リスト
        /// </summary>
        BelongingsTypeObject[] BelongingsList { get; set; }

        /// <summary>
        /// 確認Messageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        void ShowInfoMessage(string message);

        /// <summary>
        /// ワーニングMessageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        void ShowWarningMessage(string message);
    }
}

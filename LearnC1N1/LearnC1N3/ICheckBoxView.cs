using System;

namespace LearnC1N3
{
    /// <summary>
    /// チェックボックスView/インタフェース
    /// </summary>
    public　interface ICheckBoxView
    {
        /// <summary>
        /// Viewを表示する
        /// </summary>
        void Show();

        /// <summary>
        /// 決定ボタン
        /// </summary>
        Action<bool, bool, bool> DecisionButtonAction { get; set; }

        /// <summary>
        /// 確認Messageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        void ShowInfoMessage(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N2
{
    /// <summary>
    /// テキストボックス＆ラベルView/インタフェース
    /// </summary>
    public interface ITextBoxLabelView
    {
        /// <summary>
        /// Viewを表示する
        /// </summary>
        void Show();

        /// <summary>入力ボタン</summary>
        Action<string> InputButtonAction { get; set; }

        /// <summary>Inputラベル有効</summary>
        bool IsEnabledInputLabel { get; set; }

        /// <summary>InputText</summary>
        string TextInputLabel { get; set; }

        /// <summary>
        /// ワーニングMessageを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        void ShowWarningMessage(string message);
    }
}

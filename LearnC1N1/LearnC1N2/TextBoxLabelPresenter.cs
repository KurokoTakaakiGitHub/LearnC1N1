using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N2
{
    /// <summary>
    /// テキストボックス＆ラベルView・プレゼンター
    /// </summary>
    public class TextBoxLabelPresenter
    {
        /// <summary>テキストボックス＆ラベルView</summary>
        private readonly ITextBoxLabelView view;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxLabelPresenter"/> class.
        /// </summary>
        /// <param name="view">View</param>
        public TextBoxLabelPresenter(ITextBoxLabelView view)
        {
            this.view = view;
            this.view.InputButtonAction += this.InputButtonAction;
            this.view.Show();
        }

        /// <summary>
        /// インプットボタン
        /// </summary>
        private void InputButtonAction(string textBoxInputtext)
        {
            if (string.IsNullOrEmpty(textBoxInputtext))
            {
                this.view.ShowWarningMessage("未入力です。");
            }
            else
            {
                this.view.TextInputLabel = textBoxInputtext;
            }
        }
    }
}
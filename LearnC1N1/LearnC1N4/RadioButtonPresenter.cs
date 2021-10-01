using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N4
{
    /// <summary>
    /// ラジオボタンView・プレゼンター
    /// </summary>
    public class RadioButtonPresenter
    {
        /// <summary>テキストボックス＆ラベルView</summary>
        private readonly IRadioButtonView view;

        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButtonPresenter"/> class.
        /// </summary>
        /// <param name="view">View</param>
        public RadioButtonPresenter(IRadioButtonView view)
        {
            this.view = view;
            this.view.SetBackColorButtonAction += this.SetBackColorButtonAction;
            this.view.Show();
        }

        /// <summary>
        /// 背景色設定ボタン
        /// </summary>
        /// <param name="checkedRed">ラジオボタンRed</param>
        /// <param name="checkedBlue">ラジオボタンBlue</param>
        /// <param name="checkedGreen">ラジオボタンGreenC</param>
        private void SetBackColorButtonAction(bool checkedRed, bool checkedBlue, bool checkedGreen)
        {
            this.view.ViewBackColor = RadioButtonModel.GetBackCollar(checkedRed, checkedBlue, checkedGreen);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N3
{
    /// <summary>
    /// チェックボックス・プレゼンター
    /// </summary>
    public class CheckBoxPresenter
    {
        /// <summary>テキストボックス＆ラベルView</summary>
        private readonly ICheckBoxView view;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxPresenter"/> class.
        /// </summary>
        /// <param name="view">View</param>
        public CheckBoxPresenter(ICheckBoxView view)
        {
            this.view = view;
            this.view.DecisionButtonAction += this.DecisionButtonAction;
            this.view.Show();
        }

        /// <summary>
        /// 決定ボタン
        /// </summary>
        /// <param name="checkedA">チェックボックスA</param>
        /// <param name="checkedB">チェックボックスB</param>
        /// <param name="checkedC">チェックボックスC</param>
        private void DecisionButtonAction(bool checkedA, bool checkedB, bool checkedC)
        {
            try
            {
                this.view.ShowInfoMessage(CheckBoxModel.CalcItemPrice(checkedA, checkedB, checkedC));
            }
            catch (Exception e)
            {
                Program.ShowErrMessage(e.Message + "\n" + e.StackTrace);
            }
        }
    }
}
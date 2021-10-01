using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N7
{
    /// <summary>
    /// プレゼンター
    /// </summary>
    public class BirthDateCalcPresenter
    {
        private  readonly IBirthDateCalc view;

        /// <summary>
        /// Initializes a new instance of the <see cref="BirthDateCalcPresenter"/> class.
        /// </summary>
        /// <param name="view">View</param>
        public BirthDateCalcPresenter(IBirthDateCalc view)
        {
            this.view = view;
            this.view.BirthDateCalcAction += this.BirthDateCalcAction;
            this.view.Show();
        }

        /// <summary>
        /// 年齢計算
        /// </summary>
        private void BirthDateCalcAction(string inputBirthDate)
        {
            try
            {
                this.view.Message = BirthDateCalcModel.CalcBirthDate(inputBirthDate);
            }
            catch (Exception e)
            {
                Program.ShowErrMessage(e.Message + "\n" + e.StackTrace);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N1
{
    /// <summary>
    /// 年齢計算・プレゼンター
    /// </summary>
    public class AgeCalcPresenter
    {
        /// <summary>年齢計算View</summary>
        private readonly IAgeCalcView view;

        /// <summary>
        /// Initializes a new instance of the <see cref="AgeCalcPresenter"/> class.
        /// </summary>
        /// <param name="view">年齢計算View/インタフェース</param>
        public AgeCalcPresenter(IAgeCalcView view)
        {
            this.view = view;
            this.view.Show();

            try
            {
                this.view.OkButtonAction += this.OkButtonAction;
            }
            catch (Exception e)
            {
                Program.ShowErrMessage(e.Message + "\n" + e.StackTrace);
            }
        }

        /// <summary>
        /// Okボタン
        /// </summary>
        /// <param name="fullName">名前</param>
        /// <param name="birthDate">誕生日</param>
        private void OkButtonAction(string fullName, string birthDate)
        {
            try
            {
                var message = string.Empty;

                if (AgeCalcModel.GetAge(fullName, birthDate, out message))
                {
                    this.view.ShowInfoMessage(message);
                }
                else
                {
                    this.view.ShowWarningMessage(message);
                }
            }
            catch (Exception e)
            {
                Program.ShowErrMessage(e.Message + "\n" + e.StackTrace);
            }
        }
    }
}
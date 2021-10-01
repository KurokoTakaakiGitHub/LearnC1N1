using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N7
{
    /// <summary>
    /// 誕生日計算・モデル
    /// </summary>
    public class BirthDateCalcModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BirthDateCalcModel"/> class.
        /// </summary>
        public BirthDateCalcModel()
        {
        }

        /// <summary>
        /// 誕生日を計算する
        /// </summary>
        /// <returns>メッセージ</returns>
        public static string CalcBirthDate(string inputBirthDate)
        {
            try
            {
                var birthDate = new BirthDate(inputBirthDate);
                var today = DateTime.Today;
                var thisYearBirthDate = new DateTime(today.Year, birthDate.Month, birthDate.Day);

                if (thisYearBirthDate < today)
                {
                    thisYearBirthDate = new DateTime(today.Year + 1, birthDate.Month, birthDate.Day);
                }

                var days = thisYearBirthDate.Date.Subtract(today.Date).Days;

                return $"本日から次の誕生日[{thisYearBirthDate.Date.ToShortDateString()}]まではあと{days}です。";
            }
            catch (ArgumentException e)
            {
                return GetExceptUnnecessaryExceptionMessage(e.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        /// <summary>
        /// 例外メッセージ取得（不要部分削除）
        /// </summary>
        /// <param name="exceptioMessage">メッセージ</param>
        /// <returns>不要部分削除後メッセージ</returns>
        private static string GetExceptUnnecessaryExceptionMessage(string exceptioMessage)
        {
            if (string.IsNullOrEmpty(exceptioMessage))
            {
                return string.Empty;
            }

            return exceptioMessage.Split('(')[0];
        }
    }
}
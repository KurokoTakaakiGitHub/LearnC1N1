using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N4
{
    /// <summary>
    /// ラジオボタン・モデル
    /// </summary>
    public class RadioButtonModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButtonModel"/> class.
        /// </summary>
        public RadioButtonModel()
        {
        }

        /// <summary>
        /// 背景色取得
        /// </summary>
        /// <param name="checkedRed">ラジオボタンRed</param>
        /// <param name="checkedBlue">ラジオボタンBlue</param>
        /// <param name="checkedGreen">ラジオボタンGreenC</param>
        /// <returns>背景色</returns>
        public static Color GetBackCollar(bool checkedRed, bool checkedBlue, bool checkedGreen)
        {
            if (checkedRed)
            {
                return Color.Red;
            }

            if (checkedBlue)
            {
                return Color.Blue;
            }

            return Color.Green;
        }
    }
}
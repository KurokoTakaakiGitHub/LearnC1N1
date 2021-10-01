using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnC1N7;
using System;

namespace UnitProject_LearnC1N7
{
    public partial class BirthDateCalcModel_誕生日計算Model
    {
        [TestClass]
        public class CalcBirthDate_誕生日計算
        {
            [TestInitialize]
            public void 準備()
            {
            }

            #region A_次回誕生日と次回誕生日までの日数を計算して確認メッセージを出力する

            

            [TestCategory("A_次回誕生日と次回誕生日までの日数を計算して確認メッセージを出力する")]
            [TestMethod]
            public void A1_当日_を渡すとメッセージが出力_次回誕生日当日_日数0日()
            {
                // 準備
                var todayStr = DateTime.Today.GetDateTimeFormats('d')[0];
                var result = BirthDateCalcModel.CalcBirthDate(todayStr);

                var days = 0;
                var thisYearBirthDate = "2021/09/12";

                // 確認
                Assert.AreEqual($"本日から次の誕生日[{thisYearBirthDate}]まではあと{days}です。", result);
            }

            [TestCategory("A_次回誕生日と次回誕生日までの日数を計算して確認メッセージを出力する")]
            [TestMethod]
            public void A2_前日_を渡すとメッセージが出力_次回誕生日翌日_日数364日()
            {
                // 準備
                var beforeDayStr = DateTime.Today.AddDays(-1).GetDateTimeFormats('d')[0];
                var result = BirthDateCalcModel.CalcBirthDate(beforeDayStr);

                var days = 364;
                var thisYearBirthDate = "2022/09/11";

                // 確認
                Assert.AreEqual($"本日から次の誕生日[{thisYearBirthDate}]まではあと{days}です。", result);
            }

            [TestCategory("A_次回誕生日と次回誕生日までの日数を計算して確認メッセージを出力する")]
            [TestMethod]
            public void A3_前年_を渡すとメッセージが出力_次回誕生日当日_日数0日()
            {
                // 準備
                var beforeYear1DateStr = DateTime.Today.AddYears(-1).GetDateTimeFormats('d')[0];
                var result = BirthDateCalcModel.CalcBirthDate(beforeYear1DateStr);

                var days = 0;
                var thisYearBirthDate = "2021/09/28";

                // 確認
                Assert.AreEqual($"本日から次の誕生日[{thisYearBirthDate}]まではあと{days}です。", result);
            }

            [TestCategory("A_次回誕生日と次回誕生日までの日数を計算して確認メッセージを出力する")]
            [TestMethod]
            public void A4_前年翌日_を渡すとメッセージが出力_次回誕生日翌日_日数1日()
            {
                // 準備
                var beforeYear1Next1DayDateStr = DateTime.Today.AddYears(-1).AddDays(1).GetDateTimeFormats('d')[0];
                var result = BirthDateCalcModel.CalcBirthDate(beforeYear1Next1DayDateStr);

                var days = 1;
                var thisYearBirthDate = "2021/09/29";

                // 確認
                Assert.AreEqual($"本日から次の誕生日[{thisYearBirthDate}]まではあと{days}です。", result);
            }

            #endregion

            [TestCategory("B_日付変換異常")]
            [TestMethod]
            public void B1_20210930を渡すと例外処理_ArgumentExceptionとなる()
            {
                // 準備
                var todayStr = "2021/09/31";
   
                // 実施
                var result = BirthDateCalcModel.CalcBirthDate(todayStr);
                
                // 確認
                Assert.AreEqual("日付が正しく変換できません。 ",result);
            }

            [TestCategory("C_当日より以前に日付は入力できない")]
            [TestMethod]
            public void C1_翌日を渡すと例外処理__ArgumentOutOfRangeExceptionとなる()
            {
                // 準備
                var todayStr = DateTime.Today.AddDays(1).GetDateTimeFormats('d')[0];

                // 実施
                var result = BirthDateCalcModel.CalcBirthDate(todayStr);

                // 確認
                Assert.AreEqual("今日以前の日付を選択してください。 ", result);
            }            
        }
    }
}

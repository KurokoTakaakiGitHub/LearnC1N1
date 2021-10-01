using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnC1N7;
using System;

namespace UnitProject_LearnC1N7
{
    public partial class BirthDate_生年月日
    {
        [TestClass]
        public class コンストラクタ
        {
            [TestInitialize]
            public void 準備()
            {
            }

            [TestCategory("A_日付変換異常")]
            [TestMethod]
            public void A1_20210930を渡すと例外処理_ArgumentExceptionとなる()
            {
                // 準備
                var dayStr = "2021/09/31";

                // 確認
                var ex = Assert.ThrowsException<ArgumentException>(() =>
                {
                    var birthDate = new LearnC1N7.BirthDate(dayStr);
                });

                Assert.AreEqual("日付が正しく変換できません。 (Parameter 'birthDate')", ex.Message);
            }

            [TestCategory("B_当日より以前に日付は入力できない")]
            [TestMethod]
            public void B1_翌日を渡すと例外処理__ArgumentOutOfRangeExceptionとなる()
            {
                // 準備
                var nextDayStr = DateTime.Today.AddDays(1).GetDateTimeFormats('d')[0];
                
                // 確認
                var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                {
                    var birthDate = new LearnC1N7.BirthDate(nextDayStr);
                });

                Assert.AreEqual("今日以前の日付を選択してください。 (Parameter 'birthDate')", ex.Message);
            }

            [TestCategory("B_当日より以前に日付は入力できない")]
            [TestMethod]
            public void B2_当日を渡すと正常終了する()
            {
                // 準備
                var todayStr = DateTime.Today.GetDateTimeFormats('d')[0];
                var birthDate = new LearnC1N7.BirthDate(todayStr);

                // 確認
                Assert.AreEqual(new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day), birthDate.Value);
                Assert.AreEqual(DateTime.Today.Year, birthDate.Year);
                Assert.AreEqual(DateTime.Today.Month, birthDate.Month);
                Assert.AreEqual(DateTime.Today.Day, birthDate.Day);
            }
        }
    }
}

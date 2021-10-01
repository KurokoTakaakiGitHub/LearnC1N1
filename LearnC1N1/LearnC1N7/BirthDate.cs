using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N7
{
    /// <summary>
    /// 生年月日
    /// </summary>
    public class BirthDate
    {
        /// <summary>Value</summary>
        public DateTime Value { get; }

        /// <summary>年</summary>
        public int Year { get; }

        /// <summary>月</summary>
        public int Month { get; }

        /// <summary>日</summary>
        public int Day { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BirthDate"/> class.
        /// </summary>
        /// <param name="birthDate">生年月日</param>
        public BirthDate(string birthDate)
        {
            string format = "yyyy/MM/dd";

            if　(!DateTime.TryParseExact(birthDate, format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.NoCurrentDateDefault, out var checkedDate))
            {
                throw new ArgumentException("日付が正しく変換できません。", nameof(birthDate));
            }

            if (checkedDate > DateTime.Today)
            {
                throw new ArgumentOutOfRangeException(nameof(birthDate), "今日以前の日付を選択してください。");
            }

            this.Value = checkedDate;
            this.Year = checkedDate.Year;
            this.Month = checkedDate.Month;
            this.Day = checkedDate.Day;
        }
    }
}

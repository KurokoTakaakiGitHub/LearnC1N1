using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N1
{
    /// <summary>
    /// 人間
    /// </summary>
    public class Person
    {
        /// <summary>名前</summary>
        public Name Name { get; }

        /// <summary>生年月日</summary>
        public BirthDate BirthDate { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="birthDate">生年月日</param>
        public Person(Name name, BirthDate birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        /// <summary>
        /// 年齢を取得
        /// </summary>
        /// <returns>年齢</returns>
        public int GetAge()
        {
            var today = DateTime.Today;

            int age = today.Year - this.BirthDate.Year;

            // 月が過ぎてない
            if (today.Month < this.BirthDate.Month)
            {
                return age--;
            }

            // 同じ月で日が過ぎている
            if (today.Month == this.BirthDate.Month &&
                today.Day < this.BirthDate.Day)
            {
                age--;
            }

            return age;
        }
    }
}

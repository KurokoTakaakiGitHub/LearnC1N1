using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N1
{
    /// <summary>
    /// 年齢計算・モデル
    /// </summary>
    public class AgeCalcModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgeCalcModel"/> class.
        /// </summary>
        public AgeCalcModel()
        {
        }

        /// <summary>
        /// 年齢を計算する
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="birthday">生年月日</param>
        /// <param name="message">メッセージ</param>
        /// <returns>true:正常 false:異常</returns>
        public static bool GetAge(string name, string birthday, out string message)
        {
            try
            {
                var fullName = new Name(name);
                var dateOfBirth = new BirthDate(birthday);
                var age = new Person(fullName, dateOfBirth).GetAge();

                message = GetNameAgeMessage(fullName, age);
                return true;
            }
            catch (ArgumentNullException e)
            {
                message = GetExceptUnnecessaryExceptionMessage(e.Message);
                return false;
            }
            catch (ArgumentOutOfRangeException e)
            {
                message = GetExceptUnnecessaryExceptionMessage(e.Message);
                return false;
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

        /// <summary>
        /// 名前年齢メッセージ取得
        /// </summary>
        /// <param name="fullName">名前</param>
        /// <param name="age">年齢</param>
        /// <returns>名前年齢メッセージ</returns>
        private static string GetNameAgeMessage(Name fullName, int age)
        {
            return $"{fullName}さんの年齢は{age} です。";
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnC1N7;
using System;

namespace UnitProject_LearnC1N7
{
    public partial class BirthDateCalcModel_�a�����v�ZModel
    {
        [TestClass]
        public class CalcBirthDate_�a�����v�Z
        {
            [TestInitialize]
            public void ����()
            {
            }

            #region A_����a�����Ǝ���a�����܂ł̓������v�Z���Ċm�F���b�Z�[�W���o�͂���

            

            [TestCategory("A_����a�����Ǝ���a�����܂ł̓������v�Z���Ċm�F���b�Z�[�W���o�͂���")]
            [TestMethod]
            public void A1_����_��n���ƃ��b�Z�[�W���o��_����a��������_����0��()
            {
                // ����
                var todayStr = DateTime.Today.GetDateTimeFormats('d')[0];
                var result = BirthDateCalcModel.CalcBirthDate(todayStr);

                var days = 0;
                var thisYearBirthDate = "2021/09/12";

                // �m�F
                Assert.AreEqual($"�{�����玟�̒a����[{thisYearBirthDate}]�܂ł͂���{days}�ł��B", result);
            }

            [TestCategory("A_����a�����Ǝ���a�����܂ł̓������v�Z���Ċm�F���b�Z�[�W���o�͂���")]
            [TestMethod]
            public void A2_�O��_��n���ƃ��b�Z�[�W���o��_����a��������_����364��()
            {
                // ����
                var beforeDayStr = DateTime.Today.AddDays(-1).GetDateTimeFormats('d')[0];
                var result = BirthDateCalcModel.CalcBirthDate(beforeDayStr);

                var days = 364;
                var thisYearBirthDate = "2022/09/11";

                // �m�F
                Assert.AreEqual($"�{�����玟�̒a����[{thisYearBirthDate}]�܂ł͂���{days}�ł��B", result);
            }

            [TestCategory("A_����a�����Ǝ���a�����܂ł̓������v�Z���Ċm�F���b�Z�[�W���o�͂���")]
            [TestMethod]
            public void A3_�O�N_��n���ƃ��b�Z�[�W���o��_����a��������_����0��()
            {
                // ����
                var beforeYear1DateStr = DateTime.Today.AddYears(-1).GetDateTimeFormats('d')[0];
                var result = BirthDateCalcModel.CalcBirthDate(beforeYear1DateStr);

                var days = 0;
                var thisYearBirthDate = "2021/09/28";

                // �m�F
                Assert.AreEqual($"�{�����玟�̒a����[{thisYearBirthDate}]�܂ł͂���{days}�ł��B", result);
            }

            [TestCategory("A_����a�����Ǝ���a�����܂ł̓������v�Z���Ċm�F���b�Z�[�W���o�͂���")]
            [TestMethod]
            public void A4_�O�N����_��n���ƃ��b�Z�[�W���o��_����a��������_����1��()
            {
                // ����
                var beforeYear1Next1DayDateStr = DateTime.Today.AddYears(-1).AddDays(1).GetDateTimeFormats('d')[0];
                var result = BirthDateCalcModel.CalcBirthDate(beforeYear1Next1DayDateStr);

                var days = 1;
                var thisYearBirthDate = "2021/09/29";

                // �m�F
                Assert.AreEqual($"�{�����玟�̒a����[{thisYearBirthDate}]�܂ł͂���{days}�ł��B", result);
            }

            #endregion

            [TestCategory("B_���t�ϊ��ُ�")]
            [TestMethod]
            public void B1_20210930��n���Ɨ�O����_ArgumentException�ƂȂ�()
            {
                // ����
                var todayStr = "2021/09/31";
   
                // ���{
                var result = BirthDateCalcModel.CalcBirthDate(todayStr);
                
                // �m�F
                Assert.AreEqual("���t���������ϊ��ł��܂���B ",result);
            }

            [TestCategory("C_�������ȑO�ɓ��t�͓��͂ł��Ȃ�")]
            [TestMethod]
            public void C1_������n���Ɨ�O����__ArgumentOutOfRangeException�ƂȂ�()
            {
                // ����
                var todayStr = DateTime.Today.AddDays(1).GetDateTimeFormats('d')[0];

                // ���{
                var result = BirthDateCalcModel.CalcBirthDate(todayStr);

                // �m�F
                Assert.AreEqual("�����ȑO�̓��t��I�����Ă��������B ", result);
            }            
        }
    }
}

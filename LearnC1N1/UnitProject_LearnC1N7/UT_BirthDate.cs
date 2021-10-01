using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnC1N7;
using System;

namespace UnitProject_LearnC1N7
{
    public partial class BirthDate_���N����
    {
        [TestClass]
        public class �R���X�g���N�^
        {
            [TestInitialize]
            public void ����()
            {
            }

            [TestCategory("A_���t�ϊ��ُ�")]
            [TestMethod]
            public void A1_20210930��n���Ɨ�O����_ArgumentException�ƂȂ�()
            {
                // ����
                var dayStr = "2021/09/31";

                // �m�F
                var ex = Assert.ThrowsException<ArgumentException>(() =>
                {
                    var birthDate = new LearnC1N7.BirthDate(dayStr);
                });

                Assert.AreEqual("���t���������ϊ��ł��܂���B (Parameter 'birthDate')", ex.Message);
            }

            [TestCategory("B_�������ȑO�ɓ��t�͓��͂ł��Ȃ�")]
            [TestMethod]
            public void B1_������n���Ɨ�O����__ArgumentOutOfRangeException�ƂȂ�()
            {
                // ����
                var nextDayStr = DateTime.Today.AddDays(1).GetDateTimeFormats('d')[0];
                
                // �m�F
                var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                {
                    var birthDate = new LearnC1N7.BirthDate(nextDayStr);
                });

                Assert.AreEqual("�����ȑO�̓��t��I�����Ă��������B (Parameter 'birthDate')", ex.Message);
            }

            [TestCategory("B_�������ȑO�ɓ��t�͓��͂ł��Ȃ�")]
            [TestMethod]
            public void B2_������n���Ɛ���I������()
            {
                // ����
                var todayStr = DateTime.Today.GetDateTimeFormats('d')[0];
                var birthDate = new LearnC1N7.BirthDate(todayStr);

                // �m�F
                Assert.AreEqual(new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day), birthDate.Value);
                Assert.AreEqual(DateTime.Today.Year, birthDate.Year);
                Assert.AreEqual(DateTime.Today.Month, birthDate.Month);
                Assert.AreEqual(DateTime.Today.Day, birthDate.Day);
            }
        }
    }
}

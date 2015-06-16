using EvoNUnit.Test.Util;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoNUnit
{
    [TestFixture]
    public class DateUtilTest
    {
        private static readonly string CLASS_NAME = "DateUtilTest";

        //Assert equal
        [Test]
        public void DateDiffInDaysTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "DateDiffInDaysTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                int result = DateUtil.DateDiffInDays(values[0],values[1]);
                Assert.AreEqual(Int32.Parse(values[2]),result);
            }
        }

        [Test]
        public void DateStringTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "DateStringTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                string result = DateUtil.DateString(Int32.Parse(values[0]), Int32.Parse(values[1]), Int32.Parse(values[2]));
                Assert.AreEqual(values[3],result);
            }
        }

        //Assert not equal
        [Test]
        public void DateDiffInDaysPositiveTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "DateDiffInDaysPositiveTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                int result = DateUtil.DateDiffInDays(values[0], values[1]);
                Assert.AreNotEqual(-1,result);
            }
        }

        //Assert boolean
        [Test]
        public void IsLeapYearTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "IsLeapYearTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                bool result = DateUtil.IsLeapYear(Int32.Parse(values[0]));
                Assert.AreEqual(Boolean.Parse(values[1]),result);
            }
        }

        [Test]
        public void IsLeapYearTrueTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "IsLeapYearTrueTest");
            foreach (string mCase in cases)
            {
                Assert.IsTrue(DateUtil.IsLeapYear(Int32.Parse(mCase)));
            }
        }

        [Test]
        public void IsLeapYearFalseTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "IsLeapYearFalseTest");
            foreach (string mCase in cases)
            {
                Assert.IsFalse(DateUtil.IsLeapYear(Int32.Parse(mCase)));
            }
        }

        // Assert null

        [Test]
        public void DateStringCanBeNull()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "DateStringCanBeNull");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                Assert.IsNull(DateUtil.Intervalo(values[0], values[1]));
            }
        }

        // Exception tests

        [Test]
        public void IntervaloFormatExceptionTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "IntervaloFormatExceptionTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                Assert.Throws<FormatException>(() => DateUtil.Intervalo(values[0], values[1]));
            }
        }

        [Test]
        public void DateStringExceptionTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "DateStringExceptionTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                int day = Int32.Parse(values[0]);
                int month = Int32.Parse(values[1]);
                int year = Int32.Parse(values[2]);
                Assert.Throws<ArgumentOutOfRangeException>(() => DateUtil.DateString(day, month, year));
            }
        }


    }
}

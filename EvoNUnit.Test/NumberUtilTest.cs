using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EvoNUnit.Test.Util;

namespace EvoNUnit
{
    public class NumberUtilTest
    {
        private static readonly string CLASS_NAME = "NumberUtilTest";

        //Assert not equal
        [Test]
        public void GetNonZeroRandomNumberTest()
        {
            string[] input = TestUtil.ReadTests(CLASS_NAME, "GetNonZeroRandomNumberTest");
            int numberOfTests = Int32.Parse(input[0]);
            for (int i = 0; i < numberOfTests; i++)
                Assert.AreNotEqual(0, NumberUtil.GetNonZeroRandomNumber());
        }

        //Asserts lists
        [Test]
        public void ListOfPairsTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "ListOfPairsTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                int n = Int32.Parse(values[0]);
                List<int> expectedList = new List<int>();
                for (int i = 1; i < values.Length; i++)
                {
                    expectedList.Add(Int32.Parse(values[i]));
                }
                CollectionAssert.AreEqual(expectedList, NumberUtil.ListOfPairs(n));
            }
        }

        [Test]
        public void ListOfImpairsTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "ListOfImpairsTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                int n = Int32.Parse(values[0]);
                List<int> expectedList = new List<int>();
                for (int i = 1; i < values.Length; i++)
                {
                    expectedList.Add(Int32.Parse(values[i]));
                }
                CollectionAssert.AreEqual(expectedList, NumberUtil.ListOfImpairs(n));
            }
        }

        //Otros tests

        [Test]
        public void IsMultipleTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "IsMultipleTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                bool expected = Boolean.Parse(values[2]);
                int n1 = Int32.Parse(values[0]),n2 = Int32.Parse(values[1]);
                if (expected)
                    Assert.IsTrue(NumberUtil.IsMultiple(n1, n2));
                else
                    Assert.IsFalse(NumberUtil.IsMultiple(n1, n2));
            }
        }

        [Test]
        public void IsExactTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "IsExactTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                bool expected = Boolean.Parse(values[1]);
                bool result = NumberUtil.IsExact(Double.Parse(values[0]));
                Assert.AreEqual(expected, result);
            }
        }

        //[Test, MaxTime(2000)]
        [Test]
        public void VeryBasicFibonacciTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "VeryBasicFibonacciTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                Assert.AreEqual(Int32.Parse(values[1]), 
                    NumberUtil.VeryBasicFibonacci(Int32.Parse(values[0])));
            }
        }

        [Test]
        public void IsBetweenTest()
        {
            string[] cases = TestUtil.ReadTests(CLASS_NAME, "IsBetweenTest");
            foreach (string mCase in cases)
            {
                string[] values = mCase.Split(' ');
                bool expected = Boolean.Parse(values[3]);
                bool result = NumberUtil.IsBetween(
                    Int32.Parse(values[0]), Int32.Parse(values[1]), Int32.Parse(values[2]));
                Assert.AreEqual(expected, result);
            }
        }

    }
}

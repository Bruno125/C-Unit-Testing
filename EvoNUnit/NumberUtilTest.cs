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

        [Test]
        public void GetNonZeroRandomNumberTest()
        {
            string[] input = TestUtil.ReadTests(CLASS_NAME, "GetNonZeroRandomNumberTest");
            int numberOfTests = Int32.Parse(input[0]);
            for (int i = 0; i < numberOfTests; i++)
                Assert.AreNotEqual(0, NumberUtil.GetNonZeroRandomNumber());
        }

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
    }
}

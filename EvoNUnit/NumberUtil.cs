using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoNUnit
{
    public static class NumberUtil
    {
        public static int GetNonZeroRandomNumber()
        {
            Random r = new Random();
            int random;
            do
                random = r.Next();
            while (random == 0);
            return random;
        }

        public static List<int> ListOfPairs(int num)
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= num; i += 2)
                list.Add(i);
            return list;
        }


    }
}

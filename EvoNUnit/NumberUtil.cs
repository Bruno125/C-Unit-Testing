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

        public static List<int> ListOfImpairs(int num)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= num; i += 2)
                list.Add(i);
            return list;
        }

        public static bool IsMultiple(int numero, int divisor)
        {
            return (numero % divisor == 0);
        }

        public static bool IsExact(double number)
        {
            int floorNumber = (int) number;
            return (number-floorNumber)==0;
        }

        public static int VeryBasicFibonacci(int n)
        {
            if(n==0)    return 0;
            if(n==1)    return 1;
            return VeryBasicFibonacci(n - 1) + VeryBasicFibonacci(n - 2);
        }

        public static bool IsBetween(int n, int a, int b)
        {
            return (a <= n) && (n<= b);
        }
    }
}

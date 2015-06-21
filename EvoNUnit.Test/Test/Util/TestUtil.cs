using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoNUnit.Test.Util
{
    public class TestUtil
    {
        public static string[] ReadTests(string ClassName,string ClassMethod)
        {

            string[] allText = File.ReadAllLines("Test\\Inputs\\" + ClassName + ".txt");
            List<string> cases = new List<string>();
            for(int i =0;i<allText.Length;i++)
            {
                string line = allText[i];
                if (line.Trim().Equals(ClassMethod.Trim()))
                {
                    int c=1;
                    string temp = allText[i + c];
                    while (!temp.Equals("end_test"))
                    {
                        cases.Add(temp);
                        c++;
                        temp = allText[i + c];
                    }
                    break;
                }
            }
            return cases.ToArray();
        }
    }
}

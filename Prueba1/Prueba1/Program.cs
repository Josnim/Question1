using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class Program
    {
        static int LongestS(string txt)
        {
            int max = 0;
            for (int i=0; i<txt.Length; i++)
            {
                string subString = "";
                for (int j = i; j < txt.Length; j++)
                {
                    if (subString.Contains(txt.Substring(j, 1)))
                    {
                        break;
                    }
                    subString += txt.Substring(j, 1);
                    if (max < subString.Length)
                    {
                        max = subString.Length;
                    }
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(LongestS(input));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGcd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Input the First Integer Number:");
            var strNum = Console.ReadLine();
            Int64.TryParse(strNum, out var iNum1);
            Console.WriteLine("Input The Second Integer Number:");
            strNum = Console.ReadLine();
            Int64.TryParse(strNum, out var iNum2);
            var iVal1 = Math.Abs(iNum1);
            var iVal2 = Math.Abs(iNum2);
            if (iVal1 > 0 && iVal2 > 0)
            {
                while (iVal1 != iVal2)
                {
                    if (iVal1 > iVal2)
                        iVal1 -= iVal2;
                    else
                        iVal2 -= iVal1;
                }
                var nGcd = iVal1;
                Console.WriteLine("The Gcd of the numbers {0} and {1} is {2}", iNum1, iNum2, nGcd);
            }
            else
            {
                Console.WriteLine("The numbers must not be equal 0");
            }
            Console.Read();
        }
    }
}

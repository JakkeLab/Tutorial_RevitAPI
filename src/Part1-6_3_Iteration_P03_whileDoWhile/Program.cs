using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_6_3_Iteration_P03_whileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int sum1 = 0;

            while (a < 5)
            {
                sum1 += a;
                a++;
            }

            int b = 5;
            int sum2 = 0;

            do
            {
                sum2 += b;
                b++;
            } while (b < 5);

            Console.WriteLine($"첫번째 결과 : {sum1}, 두번째 결과 : {sum2}");


            //종료방지용
            Console.Read();
        }
    }
}

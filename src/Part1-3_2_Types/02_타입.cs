using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_3_2_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("예제1번");
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);           //30 출력

            Console.WriteLine("\n예제2번");
            double d1 = 10.23;
            double d2 = 5.01;
            Console.WriteLine(d1 + d2);         //15.24 출력

            Console.WriteLine("\n예제3번");
            string str1 = "Revit";
            string str2 = "Programming";
            Console.WriteLine(str1 + str2);     //RevitProgramming 출력

            Console.WriteLine("\n예제4번");
            char c1 = 'R';
            char c2 = 'V';
            char c3 = 'T';
            Console.WriteLine(c1 + c2 + c3);    //252 출력
            Console.WriteLine(c1.ToString() + c2 + c3);    //RVT 출력

            //종료 방지용.
            Console.ReadLine();
        }
    }
}

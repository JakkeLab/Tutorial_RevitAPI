using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_6_2_Iteration_P02_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ingredients = new List<string>()
            {
            "양파",
            "애호박",
            "두부",
            "무",
            "된장",
            "차돌박이"
            };

            Console.WriteLine("나의 장바구니");
            Console.WriteLine("==========");

            int index = 1;
            foreach (string ingredient in ingredients)
            {
                Console.WriteLine($"{index++}. {ingredient}");
            }
            Console.WriteLine("==========");

            //종료 방지용
            Console.Read();
        }
    }
}

using System;

namespace Part1_5_2_MultipleCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문자열 입력받기
            Console.Write("문자열 1개 입력 : ");
            string input = Console.ReadLine();

            //조건문
            if (input == "기둥" || input == "계단")
            {
                Console.WriteLine("구조");
            }
            else
            {
                Console.WriteLine("구조가 아님");
            }

            //종료 방지용
            Console.Write("------\n");
            Console.Write("문자열 입력 시 종료 : ");
            Console.ReadLine();
        }
    }
}

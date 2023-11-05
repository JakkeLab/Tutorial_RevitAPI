using System;

namespace Part1_5_1_ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문자열 입력받기
            Console.Write("문자열 1개 입력 : ");
            string input = Console.ReadLine();

            //조건문
            if(input == "기둥")
            {
                Console.WriteLine("기둥입니다.");
            }
            else if (input == "계단")
            {
                Console.WriteLine("계단입니다.");
            }
            else
            {
                Console.WriteLine("기둥이나 계단이 아닙니다");
            }

            //종료 방지용
            Console.Write("------\n");
            Console.Write("문자열 입력 시 종료 : ");
            Console.ReadLine();
        }
    }
}

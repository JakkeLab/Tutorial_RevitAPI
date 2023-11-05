using System;

namespace Part1_5_5_SwitchCasePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문자열 입력받기
            Console.Write("종이크기 입력 : ");
            string input = Console.ReadLine();

            //분기설정
            switch (input)
            {
                case "A4":
                    Console.WriteLine("210x297");
                    break;
                case "A3":
                    Console.WriteLine("297x420");
                    break;
                case "A2":
                    Console.WriteLine("420x594");
                    break;
                case "A1":
                    Console.WriteLine("594x841");
                    break;
                default:
                    Console.WriteLine("잘못된 입력값");
                    break;
            }

            //종료 방지용
            Console.Write("------\n");
            Console.Write("문자열 입력 시 종료 : ");
            Console.ReadLine();
        }
    }
}

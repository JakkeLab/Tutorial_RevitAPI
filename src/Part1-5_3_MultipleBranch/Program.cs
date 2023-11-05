using System;

namespace Part1_5_3_MultipleBranch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문자열 입력받기
            Console.Write("정수 1개 입력 : ");
            string input = Console.ReadLine();

            //정수인지 검사
            int a;
            bool isInt = int.TryParse(input, out a);
            if(isInt)
            {
                if (0 < a && a < 10)
                {
                    Console.WriteLine("자릿수 : 1");
                }
                else if (10 <= a && a < 100)
                {
                    Console.WriteLine("자릿수 : 2");
                }
                else if (100 <= a && a < 1000)
                {
                    Console.WriteLine("자릿수 : 3");
                }
                else
                {
                    Console.WriteLine("범위 초과");
                }
            }
            else
            {
                Console.WriteLine("올바르지 않은 값 입력");
            }

            //종료 방지용
            Console.Write("------\n");
            Console.Write("문자열 입력 시 종료 : ");
            Console.ReadLine();
        }
    }
}

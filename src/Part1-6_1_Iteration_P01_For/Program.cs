using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_6_1_Iteration_P01_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //첫 번째 정수 입력
            Console.Write("첫번째 값 입력 : ");
            string a = Console.ReadLine();
            int num1;
            bool result1 = int.TryParse(a, out num1);

            //두 번째 정수 입력
            Console.Write("첫번째 값 입력 : ");
            string b = Console.ReadLine();
            int num2;
            bool result2 = int.TryParse(b, out num2);

            //둘 다 정수인지 검사하고, 둘 중 하나라도 정수가 아니면 종료 처리
            if (!result1 || !result2)
            {
                Console.WriteLine("둘 다 정수로 입력해주세요");
                Console.ReadLine();
                return;
            }
            else
            {
                //값을 계속 더해서 저장할 변수 생성
                int sum = 0;
                int min;
                int max;
                if (num1 < num2)
                {
                    min = num1;
                    max = num2;
                }
                else
                {
                    min = num2;
                    max = num1;
                }

                //값 더하기
                for (int i = min; i < max + 1; i++)
                {
                    sum += i;
                }

                //결과 출
                Console.WriteLine("결과 : " + sum);
            }

            //종료 방지
            Console.ReadLine();
        }
    }
}

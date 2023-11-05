using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_5_4_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "기둥":
                    Console.WriteLine("기둥입니다");
                    break;
                case "계단":
                    Console.WriteLine("계단입니다");
                    break;
                default:
                    Console.WriteLine("기둥이나 계단이 아닙니다.");
                    break;
            }
        }
    }
}

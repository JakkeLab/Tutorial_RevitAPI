using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Part1_3_1_WriteCode
{
    //클래스
    public class WriteCode
    {
        public string MyName;
        //메소드(함수)
        static void Main(string[] args)
        {
            //메소드 내에서 실행하는 내용
            Greeting greeting = new Greeting();
            greeting.Name = "Jakke";
            greeting.SayHello();

            //종료 방지용.
            Console.ReadLine();
        }
    }
    
    //클래스
    public class Greeting
    {
        //필드
        public string Name;

        //메소드(함수)
        public void SayHello()
        {
            Console.WriteLine("Hello, " + this.Name);
        }
    }
}






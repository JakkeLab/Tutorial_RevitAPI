﻿using System;
using OOP.Basic.Furnitures;

namespace _01_Basic
{
    public class GetOrder
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("책상 주문하기");
            Console.WriteLine("==========");
            Console.WriteLine("주문 방법 선택하기");
            Console.WriteLine("1. 기본형 책상 구매하기(1200*600*750, 메이플 옵션");
            Console.WriteLine("2. 크기만 정해서 구입하기(메이플 상판)");
            Console.WriteLine("3. 1200*600 책상의 상판만 바꿔서 구매하기");
            Console.WriteLine("4. 전부 커스텀 하기");
            Console.WriteLine("==========");

            while (true)
            {
                Console.Write("구매 방법을 선택하세요 : ");
                int order = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Desk desk;
                switch (order)
                {
                    case 1:
                        //기본형 책상 생성
                        desk = new Desk();
                        Console.WriteLine("=========");
                        Console.WriteLine("구매내역");
                        Console.WriteLine($"규격 : {desk.GetSize()}");
                        Console.WriteLine($"상판 : {desk.GetTableTop()}");
                        Console.WriteLine($"가격 : {desk.GetPrice()}");
                        Console.WriteLine("=========");
                        break;

                    case 2:
                        //커스텀 크기 설정
                        desk = new Desk("Mahogany", 150000);
                        Console.WriteLine("=========");
                        Console.WriteLine("구매내역");
                        Console.WriteLine($"규격 : {desk.GetSize()}");
                        Console.WriteLine($"상판 : {desk.GetTableTop()}");
                        Console.WriteLine($"가격 : {desk.GetPrice()}");
                        Console.WriteLine("=========");
                        break;
                    case 3:
                        //상판만 변경
                        desk = new Desk(1200, 600, 750, 100000);
                        Console.WriteLine("=========");
                        Console.WriteLine("구매내역");
                        Console.WriteLine($"규격 : {desk.GetSize()}");
                        Console.WriteLine($"상판 : {desk.GetTableTop()}");
                        Console.WriteLine($"가격 : {desk.GetPrice()}");
                        Console.WriteLine("=========");
                        break;
                    case 4:
                        //전부 커스텀
                        desk = new Desk(1800, 700, 750, "White", 220000);
                        Console.WriteLine("=========");
                        Console.WriteLine("구매내역");
                        Console.WriteLine($"규격 : {desk.GetSize()}");
                        Console.WriteLine($"상판 : {desk.GetTableTop()}");
                        Console.WriteLine($"가격 : {desk.GetPrice()}");
                        Console.WriteLine("=========");
                        break;
                    default:
                        Console.WriteLine("잘못 입력하였습니다. 다시 입력해 주세요.");
                        break;
                }
                Console.WriteLine("주문내역을 더 확인하겠습니까?(Y/N)");
                string checkNewOrder = Console.ReadLine();
                if (checkNewOrder == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("주문확인을 끝냅니다.");
                }
            }
        }
    }
}
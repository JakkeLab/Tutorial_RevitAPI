using System;
using OOP.Basic.Furnitures;
using static OOP.Basic.Furnitures.Desk;

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
            Console.WriteLine("5. 상판 종류 보기");
            Console.WriteLine("6. 책상 종류별 기본사이즈 가격 보기");
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
                        desk = new Desk(1800, 700, 750, TableTops.NotDefined, 220000);
                        Console.WriteLine("=========");
                        Console.WriteLine("구매내역");
                        Console.WriteLine($"규격 : {desk.GetSize()}");
                        Console.WriteLine($"상판 : {desk.GetTableTop()}");
                        Console.WriteLine($"가격 : {desk.GetPrice()}");
                        Console.WriteLine("=========");
                        break;
                    case 5:
                        Console.WriteLine(Desk.ShowTableTops());
                        break;
                    case 6:
                        Console.WriteLine(GetAllDeskPrices());
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

        public int GetPrice(Desk desk)
        {
            return desk.GetPrice();
        }

        public static string GetAllDeskPrices()
        {
            string result = string.Empty;
            var ashDesk = new AshDesk();
            var mapleDesk = new MapleDesk();
            var mahoganyDesk = new MahoganyDesk();
            result += $"{ashDesk.TableTop} 책상({ashDesk.GetSize()}) : {ashDesk.GetPrice()}\n";
            result += $"{mapleDesk.TableTop} 책상({mapleDesk.GetSize()}) : {mapleDesk.GetPrice()}\n";
            result += $"{mahoganyDesk.TableTop} 책상({mahoganyDesk.GetSize()}) : {mahoganyDesk.GetPrice()}\n";

            return result;
        }
    }
}
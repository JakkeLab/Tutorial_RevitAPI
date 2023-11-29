using System;

namespace OOP.Basic.Furnitures
{
    //책상 클래스
    public class Desk
    {
        #region 책상의 속성
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public TableTops TableTop { get; set; }
        public int Price { get; set; }
        #endregion

        #region 책상 유형 기본값
        public enum TableTops
        {
            NotDefined,
            Maple,
            Mahogany,
            Ash
        }
        #endregion

        #region 책상관련 메소드

        //상판 종류 보여주기
        public static string ShowTableTops()
        {
            string result = string.Empty;
            int cnt = 1;
            foreach(TableTops tb in Enum.GetValues(typeof(TableTops)))
            {
                if(tb != TableTops.NotDefined)
                {
                    result += $"{cnt}. {tb}\n";
                    cnt++;
                }
            }
            return result;
        }

        //책상의 크기 정보 받기
        public string GetSize()
        {
            return $"W : {this.Width}, L : {this.Length}, H : {this.Height}";
        }

        //책상의 상판 정보 받기
        public TableTops GetTableTop()
        {
            return this.TableTop;
        }

        public int GetPrice()
        {
            return this.Price;
        }
        #endregion

        #region 책상 생성자

        //기본 책상 생성
        public Desk()
        {
            this.Width = 1200;
            this.Length = 600;
            this.Height = 750;
            this.TableTop = TableTops.NotDefined;
            this.Price = 80000;
        }

        //규격과 가격을 직접 입력해서 생성
        public Desk(double width, double length, double height, int price)
        {
            this.Width = width;
            this.Length = length;
            this.Height = height;
            this.TableTop = TableTops.NotDefined;
            this.Price = price;
        }

        //상판만 직접 지정해서 생성
        public Desk(string tableTop, int price)
        {
            this.Width = 1200;
            this.Length = 600;
            this.Height = 750;
            this.TableTop = TableTops.NotDefined;
            this.Price = price;
        }

        //전부 옵션을 지정해서 생성하기
        public Desk(double width, double length, double height, TableTops tableTop, int price)
        {
            this.Width = width;
            this.Length = length;
            this.Height = height;
            this.TableTop = tableTop;
            this.Price = price;
        }
        #endregion
    }
}
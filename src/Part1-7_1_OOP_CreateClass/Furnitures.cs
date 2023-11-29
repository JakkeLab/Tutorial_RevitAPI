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
        public string TableTop { get; set; }
        public int Price { get; set; }
        #endregion

        #region 책상관련 메소드
        //책상의 크기 정보 받기
        public string GetSize()
        {
            return $"W : {this.Width}, L : {this.Length}, H : {this.Height}";
        }

        //책상의 상판 정보 받기
        public string GetTableTop()
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
            this.TableTop = "Maple";
            this.Price = 80000;
        }

        //규격과 가격을 직접 입력해서 생성
        public Desk(double width, double length, double height, int price)
        {
            this.Width = width;
            this.Length = length;
            this.Height = height;
            this.TableTop = "Maple";
            this.Price = price;
        }

        //상판만 직접 지정해서 생성
        public Desk(string tableTop, int price)
        {
            this.Width = 1200;
            this.Length = 600;
            this.Height = 750;
            this.TableTop = tableTop;
            this.Price = price;
        }

        //전부 옵션을 지정해서 생성하기
        public Desk(double width, double length, double height, string tableTop, int price)
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
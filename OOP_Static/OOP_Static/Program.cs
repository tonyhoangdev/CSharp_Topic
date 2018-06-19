using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static
{
    // Bien tinh
    class Cat
    {
        public int Height { get; set; }
        public int Weight { get; set; }

        public static int count = 0;

        public Cat()
        {
            Height = 100;
            Weight = 50;
            count++;
        }
    }

    // Lop tinh, phuong thuc tinh
    static class TienIch
    {
        public static double Pow(double x, int y)
        {
            double kq = 1;
            for (int i = 0; i < y; i++)
            {
                kq *= x;
            }

            return kq;
        }
    }

    class MauSac
    {
        private static string mauChinh;

        public static string MauChinh { get => mauChinh; set => mauChinh = value; }

        // Ham tao tinh
        static MauSac()
        {
            DateTime now = DateTime.Now;

            switch (now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    MauChinh = "Xanh duong";
                    break;
                case DayOfWeek.Tuesday:
                    MauChinh = "Mau do";
                    break;
                case DayOfWeek.Wednesday:
                    MauChinh = "Mau tim";
                    break;
                case DayOfWeek.Thursday:
                    MauChinh = "Mau hong";
                    break;
                case DayOfWeek.Friday:
                    MauChinh = "Mau den";
                    break;
                case DayOfWeek.Saturday:
                    MauChinh = "Mau xanh la";
                    break;
                case DayOfWeek.Sunday:
                    MauChinh = "Mau vang";
                    break;
                default:
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Vi du ve bien tinh

            Console.WriteLine("So luong meo ban dau: " + Cat.count);

            Cat whiteCat = new Cat();
            Console.WriteLine("So luong meo hien tai: " + Cat.count);

            Cat blackCat = new Cat();
            Console.WriteLine("So luong meo hien tai: " + Cat.count);

            #endregion

            #region Vi du ve phuong thuc tinh
            Console.WriteLine("Pow: " + TienIch.Pow(2, 6));

            #endregion

            #region Vi du ve constructor tinh
            Console.WriteLine("Mau chinh cua hom nay la: " + MauSac.MauChinh);
            #endregion
        }
    }
}

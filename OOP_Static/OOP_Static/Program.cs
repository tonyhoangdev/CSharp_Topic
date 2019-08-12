using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Destructors
// Static members
// Static classes
// this and readonly
namespace OOP_Static
{
    // Bien tinh
    // Phuong thuc tinh
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

        public static void Speak()
        {
            Console.WriteLine("Meow");
        }
    }

    // Lop tinh (Lop tinh chi chua cac thanh phan tinh): Khong tao duoc doi tuong
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

        // Ham tao tinh: Khoi tao cac member tinh
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

    // Constant members are static by definition.
    class MathClass
    {
        public const int ONE = 1;
        public const int TWO = 2;
        public const int THREE = 3;
        public const int FOUR = 4;
        public const int FIVE = 5;
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
            Cat.Speak();
            #endregion

            #region Vi du ve lop tinh, phuong thuc tinh
            Console.WriteLine("Pow: " + TienIch.Pow(2, 6));
            #endregion

            #region Constant members are static by definition.
            Console.WriteLine("MathClass: " + MathClass.THREE);
            #endregion

            #region Vi du ve constructor tinh
            Console.WriteLine("Mau chinh cua hom nay la: " + MauSac.MauChinh);
            #endregion
        }
    }
}

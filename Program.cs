using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{
    class Hinhhoc
    {
        public virtual void xuat()
        {
            Console.Write("Hình Gì");
        }

        class tamgiac : Hinhhoc
        {
            public override void xuat()
            {
                Console.Write("Hình Tam Giác");
            }
        }
        class tugiac : Hinhhoc
        {
            public override void xuat()
            {
                Console.Write("Hình Tứ Giác");
            }
        }
        class hinhbinhhanh : Hinhhoc
        {
            public override void xuat()
            {
                Console.Write("Hình Bình Hành");
            }
        }
        class hinhchunhat : Hinhhoc
        {
            public override void xuat()
            {
                Console.Write("Hình Chữ nhật");
            }
        }
        class vuong : Hinhhoc
        {
            public override void xuat()
            {
                Console.Write("Hình vuông");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn hình");
            switch (Console.ReadLine())
            {
                case "Hình vuông":
                    Hinhhoc hvuong = new vuong();
                    hvuong.xuat();
                    break;

                case "Hình tam giác":
                    Hinhhoc tg = new tamgiac();
                    tg.xuat();
                    break;
                case "Hình chữ nhật":
                    Hinhhoc cn = new hinhchunhat();
                    cn.xuat();
                    break;
                case "Hình bình hành":
                    Hinhhoc hbh = new hinhbinhhanh();
                    hbh.xuat();
                    break;
                case "Hình tứ giác":
                    Hinhhoc tug = new tugiac();
                    tug.xuat();
                    break;
                default:
                    Console.WriteLine("Chọn hình");
                    break;
            }

            Console.ReadKey();
        }
    }
}

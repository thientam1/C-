using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Nguoi[] tv2 = new Nguoi[4];
            for (int i = 0; i < 3; i++)
            {
                tv2[i] = new Nguoi();
                tv2[i].nhapThongTin();
            }
            HoGiaDinh hd = new HoGiaDinh(4, 4, tv2);
            Console.WriteLine("Cac ho da nhap: ");
            hd.inThongTin();
            Console.WriteLine("---***************---");
            Console.WriteLine("---***************---");
            Console.ReadKey();
        }
    }
}

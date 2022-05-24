using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC
{
    class HoGiaDinh : Nguoi
    {
        private int soThanhVien;
        private int soNha;
        private Nguoi[] thanhVien = new Nguoi[10];

        public HoGiaDinh()
        {

        }
        public HoGiaDinh(int soThanhVien, int soNha, Nguoi[] thanhVien)
        {
            this.soThanhVien = soThanhVien;
            this.soNha = soNha;
            this.thanhVien = thanhVien;
        }
        public void nhapTT()
        {
            Console.Write("So thanh vien trng gia dinh: ");
            soThanhVien = int.Parse(Console.ReadLine());
            Console.Write("So nha:");
            soNha = int.Parse(Console.ReadLine());
            Console.WriteLine("Thong tin tung thanh vien: ");
            for (int i = 0; i < this.soThanhVien; i++)
            {
                Console.Write("thanh vien {0}", i + 1);
                this.thanhVien[i] = new Nguoi();
                this.thanhVien[i].nhapThongTin();
            }
        }
        public void inThongTin()
        {
            Console.WriteLine("So thanh vien: " + this.soThanhVien);
            Console.WriteLine("So nha: " + this.soNha);
            Console.WriteLine("Cac thanh vien trong gia dinh: ");
            try
            {
                for (int i = 0; i < this.soThanhVien; i++)
                {
                    this.thanhVien[i].inThongTin();
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine();
            }

        }
    }
}

    

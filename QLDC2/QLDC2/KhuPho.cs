using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC2
{
    class KhuPho:HoGiaDinh
    {
        public int soHoDan { get; set; }
        HoGiaDinh[] hgd = new HoGiaDinh[10];
        public KhuPho()
        {

        }
        public void nhapTT1()
        {
            Console.Write("So ho gia dinh trong khu: ");
            soThanhVien = int.Parse(Console.ReadLine());
            Console.WriteLine("Thong tin tung ho gia dinh: ");
            for (int i = 0; i < this.soHoDan; i++)
            {
                Console.Write("ho gia dinh {0}", i + 1);
                this.hgd[i] = new HoGiaDinh();
                this.hgd[i].nhapTT();
            }
        }
        public void inTT1()
        {
           
            Console.WriteLine("Cac ho gia dinh trong khu pho: ");

            for (int i = 0; i < this.soHoDan; i++)
            {
                this.hgd[i].inTT();
            }


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC2
{
    class HoGiaDinh : Nguoi
    {
        /*
        private List<Nguoi> nguois;
        private String sonha;

        public HoGiaDinh(List<Nguoi> nguois, string sonha)
        {
            nguois = nguois;
            this.sonha = sonha;
        }
        public List<Nguoi> getNguois()
        {
            return nguois;
        }

        public void setNguois(List<Nguoi> nguois)
        {
            this.nguois = nguois;
        }

        public String getSonha()
        {
            return sonha;
        }

        public void setSonha(String sonha)
        {
            this.sonha = sonha;
        }
        */
            

        
        public int soThanhVien { get; set; }
        public string soNha{ get; set; }
        Nguoi[] thanhVien = new Nguoi[10];
        public HoGiaDinh()
        {

        }
        
        public void nhapTT()
        {
            Console.Write("So thanh vien trong gia dinh: ");
            soThanhVien = int.Parse(Console.ReadLine());
            Console.Write("So nha:");
            soNha = Console.ReadLine();
            Console.WriteLine("Thong tin tung thanh vien: ");
            for (int i = 0; i < this.soThanhVien; i++)
            {
                Console.Write("thanh vien {0}", i + 1);
                this.thanhVien[i] = new Nguoi();
                this.thanhVien[i].nhapThongTin();
            }
        }
        public void inTT()
        {
            Console.WriteLine("So thanh vien: " + this.soThanhVien);
            Console.WriteLine("So nha: " + this.soNha);
            Console.WriteLine("Cac thanh vien trong gia dinh: ");
            
                for (int i = 0; i < this.soThanhVien; i++)
                {
                    this.thanhVien[i].inThongTin();
                }
           

        }
        
    }
}

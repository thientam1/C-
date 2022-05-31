using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC2
{
    class Nguoi
    {
        /*
        private String ten;
        private int tuoi;
        private String nghe;
        private String cmnd;

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Nghe { get => nghe; set => nghe = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }

        public Nguoi(string ten, int tuoi, string nghe, string cmnd)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Nghe = nghe;
            this.Cmnd = cmnd;
        }
        
       */


        
        public string Ten { get; set ; }
        public string Tuoi { get ; set ; }
        public string NgheNghiep { get ; set; }
        public string Cmnn { get; set; }

        public Nguoi(string ten, string tuoi, string ngheNghiep, string cmnn)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.NgheNghiep = ngheNghiep;
            this.Cmnn = cmnn;
        }

        public Nguoi()
        {
        }
        
        public void nhapThongTin()
        {

            Console.Write("Ten: ");
            Ten = Console.ReadLine();
            Console.Write("Tuoi: ");
            Tuoi = Console.ReadLine();
            Console.Write("Nghe Nghiep: ");
            NgheNghiep = Console.ReadLine();
            Console.Write("CMNN: ");
            Cmnn = Console.ReadLine();

        }
        public void inThongTin()
        {
                    
            Console.WriteLine("Ten: {0}", this.Ten);
            Console.WriteLine("Tuoi: {0}", this.Tuoi);
            Console.WriteLine("Nghe Nghiep: {0}", this.NgheNghiep);
            Console.WriteLine("CMNN: {0}", this.Cmnn);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC
{
    public class Nguoi
    {
        private string ten, ngheNghiep;
        private int tuoi, cmnn;
        
        
        public Nguoi()
        {

        }
        public Nguoi(string ten, int tuoi, string ngheNghiep, int cmnn)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.ngheNghiep = ngheNghiep;
            this.cmnn = cmnn;
        }
        

        public void nhapThongTin()
        {
            
            Console.Write("Ten: ");
            ten = Console.ReadLine();
            Console.Write("Tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nghe Nghiep: ");
            ngheNghiep = Console.ReadLine();
            Console.Write("CMNN: ");
            cmnn = int.Parse(Console.ReadLine());

        }
        public void inThongTin()
        {
            Console.WriteLine("Ten: {0}", ten);
            Console.WriteLine("Tuoi: {0}", tuoi);
            Console.WriteLine("Nghe Nghiep: {0}", ngheNghiep);
            Console.WriteLine("CMNN: {0}", cmnn);
        }
       

    }
}

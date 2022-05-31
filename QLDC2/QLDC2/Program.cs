using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC2
{
    class Program
    {
        static void Main(string[] args)
        {
            KhuPho kp = new KhuPho();
            kp.nhapTT1();
            kp.inTT1();
            Console.ReadKey();
        }
    }
}

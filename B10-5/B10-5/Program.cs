using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,tmp;
            int[] a148 = new int[10];
            Console.WriteLine("nhap 10 so nguyen");
            for ( i =0; i < 10; i++)
            {
                Console.Write("so thu {0} = ", (i + 1));
                a148[i] = int.Parse(Console.ReadLine());
            }
            int max = a148[0];
            int min = a148[0];
            for (i = 0; i < 9; i++)
            {
                if (a148[i] > max)
                {
                    max = a148[i];
                }


                if (a148[i] < min)
                {
                    min = a148[i];
                }
            }
            Console.WriteLine("\n\n So lon nhat la: {0}", max);
            Console.WriteLine("\n\n So nho nhat la: {0}", min);
            for (i = 0; i < 9; i++)
            {
                for (j = i + 1; j < 9; j++)
                {
                    if (a148[i] < a148[j])
                    {
                        //cach trao doi gia tri
                        tmp = a148[i];
                        a148[i] = a148[j];
                        a148[j] = tmp;
                    }
                }
            }

            Console.Write("\nsap xep theo thu tu giam dan:\n");
            for (i = 0; i < 9; i++)
            {
                Console.Write("{0}  ", a148[i]);
            }
            for ( i = 0; i < 9; i++)
            {
                for ( j = i + 1; j < 9; j++)
                {
                    if (a148[i] > a148[j])
                    {
                       
                         tmp = a148[i];
                        a148[i] = a148[j];
                        a148[j] = tmp;
                    }
                }
            }
            Console.Write("\nsap xep theo thu tu tangdan:\n");
            for ( i = 0; i < 9; i++)
            {
                Console.Write(a148[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

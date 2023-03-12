using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console__ekranı
{
    internal class matematik
    {
        public int topla (int s1, int s2)
        {
            int s3 = s1+s2;
            Console.WriteLine("Sonuç : "+ s3);
            
            return s3 ;


        }
        public int çarp (int k1, int k2) 
        {

        int k3= k1*k2;
            Console.WriteLine("Sonuç" + k3);
            return k3 ;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console__ekranı
{
    internal class kisiler : Program
    {
        public void kisi (string adsoy) 
        {
            for (int i =1; i<= 20; i++)
            {
                Console.WriteLine(i+" = "+adsoy);
            }

        }
    }
}

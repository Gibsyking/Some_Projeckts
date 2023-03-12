using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_oluşturma_Nesne_Kavramı
{
    internal class Class2 : Class3
    {
        public string isim;

        public int model;

        public double fiyat;

        private int yil;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }
 
       

    }
}

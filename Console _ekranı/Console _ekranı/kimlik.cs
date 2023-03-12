using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console__ekranı
{
    internal class kimlik
    {
        string ad;
        string soy;
        int yas;
        double kilo;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); } 
        }
        public string SOY
        {
            get { return soy; }
            set { soy = value.ToUpper(); }
        }
        public int YAS
        {
            get { return yas; }
            set { yas =Math.Abs(value); }
        }
        public double KILO
        {
            get { return kilo; }
            set { kilo = Math.Abs(value);}
        }

    }
}

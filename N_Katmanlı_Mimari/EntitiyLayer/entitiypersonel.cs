using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    public class entitiypersonel
    {
        private int id;
        private string ad;
        private string soy;
        private string sehir;
        private string gorev;
        private short maas;
        // yeni açılan class libari üzerinde kampsülleme ( properties) lernir ctrl r ve e basarak get ile okuma set value atama

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soy { get => soy; set => soy = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public short Maas { get => maas; set => maas = value; }
    }
}

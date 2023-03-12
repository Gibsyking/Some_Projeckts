using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using DataAccesLayer;
using System.Security.Cryptography.X509Certificates;

namespace Logic
{
    public class LogicPersonel
    {
        public static List<entitiypersonel> LLpersonellistesi() // personel listeleme katmanı
        {
            return DALpersonel.personellistesi();
        }
        public static int LLpersonelekle(entitiypersonel p) // personel ekleme katmanı
        {
            if (p.Ad != "" && p.Soy != "" && p.Maas>=3500 && p.Ad.Length >= 3)
            {
                return DALpersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
            
        }
        public static bool LLpersonelsil(int per) // personel silme katmanı
        {
            if (per >= 1)
            {
                return DALpersonel.Personelsil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLpersonelGuncelle(entitiypersonel ent) // personel güncelleme katmanı.
        {
            if(ent.Ad.Length>3 && ent.Maas>=3000 && ent.Ad != "")
            {
                return DALpersonel.PeronelGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}

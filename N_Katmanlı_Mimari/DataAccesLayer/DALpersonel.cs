using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntitiyLayer;

namespace DataAccesLayer
{
    public class DALpersonel
    {
        public static List<entitiypersonel> personellistesi()
        {
            List<entitiypersonel> degerler = new List<entitiypersonel>();
            SqlCommand komut1 = new SqlCommand("Select * From TBL_BİLGİ", baglantı.bgl);
            if (komut1.Connection.State != ConnectionState.Open) // eğer bağlantı açık değilse aç
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                entitiypersonel ent = new entitiypersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soy = dr["SOYAD"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);



            }
            dr.Close();
            return personellistesi();

        }
        public static int PersonelEkle(entitiypersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBL_BİLGİ (AD,SOYAD,SEHIR,GOREV,MAAS) VALUES (@P1,@P2,@P3,@P4,@P5)", baglantı.bgl);
            if (komut2.Connection.State != ConnectionState.Open) // katmanlı ekleme
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soy);
            komut2.Parameters.AddWithValue("@p3", p.Sehir);
            komut2.Parameters.AddWithValue("@p4", p.Gorev);
            komut2.Parameters.AddWithValue("@p5", p.Maas);
            return komut2.ExecuteNonQuery();



        }
        public static bool Personelsil(int p)
        {
            SqlCommand komut3= new SqlCommand("Delete From TBL_BİLGİ Where ID=@p1",baglantı.bgl);// katmanlı silme
            if (komut3.Connection.State != ConnectionState.Open) // eğer bağlantı açık değilse aç
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery()>0; // true olan değerleri sil.
        }
        public static bool PeronelGuncelle(entitiypersonel ent) 
        {
            SqlCommand komut4 = new SqlCommand("UPDATE TBL_BİLGİ SET AD=@P1,SOYAD=@P2,SEHIR=@P3,GOREV=@P4,MAAS=@P5 WHERE ID=@P6", baglantı.bgl);
            if (komut4.Connection.State != ConnectionState.Open) // katmanlı ekleme
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", ent.Ad);
            komut4.Parameters.AddWithValue("@p2", ent.Soy);
            komut4.Parameters.AddWithValue("@p3", ent.Sehir);
            komut4.Parameters.AddWithValue("@p4", ent.Gorev);
            komut4.Parameters.AddWithValue("@p5", ent.Maas);
            komut4.Parameters.AddWithValue("@p6", ent.Id);
            return komut4.ExecuteNonQuery()>0;
        }
    }
}


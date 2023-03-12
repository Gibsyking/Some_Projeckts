using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Console__ekranı
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //int sayi;
            //string isim;


            //sayi = 2 + 1;
            //isim = "Rıdvan Baba ";

            //Console.WriteLine(sayi);
            //Console.Write(isim);


            //Console.ReadKey();
            //////////////////

            //Class1 h = new Class1();
            //{
            //    h.metin();
              
            //    Console.Read();
            //}
            //////////////////////////////////

           /// kisiler ks= new kisiler();

            //string rr;


            //Console.Write("Veri Girişi Yapınız.");
            //rr = Console.ReadLine();
            //ks.kisi(rr);

            ////ks.kisi("Merhaba");
            //Console.Read();
            ////////////////////////

            //matematik mt= new matematik();

            //mt.topla(15 , 16);
            //Console.WriteLine();



            //matematik kk= new matematik();

            //kk.çarp(100, 3);
            //Console.WriteLine();






            //Console.Read();




            //tekrar çalışılması lazım....
            ///////***bilgi blg = new bilgi();

            //////...Console.WriteLine(blg);



           

            //Console.WriteLine(blg);
            /////////////////////////////////
            ///KİMLİK BİLGİLERİ////
            ///
            kimlik km= new kimlik();

            km.AD = "Rıdvan";
            km.SOY = "Aydın";
            km.YAS = 33;
            km.KILO = 95.350;

            Console.WriteLine(km.AD);  
            Console.WriteLine(km.SOY);
            Console.WriteLine(km.YAS);
            Console.WriteLine(km.KILO);







            
            
            Console.Read();

        }
    }
}

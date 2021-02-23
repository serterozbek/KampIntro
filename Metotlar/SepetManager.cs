using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention ---> E büyük yazılır.
        //syntax
        public void Ekle(Urun urun) //Urun urun -- tipi, vereceğim isimlendirme
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "+urun.Adi);

        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoHomeWork
{
    class MusteriMenager
    {
        public void Ekle (MusteriClass musteri)
        {
           Console.WriteLine("Yeni Müşteri : " + musteri.AdSoyad);
           
        }
        public void Sil(MusteriClass musteri)
        {
            Console.WriteLine(musteri.AdSoyad);


        }
    }
}

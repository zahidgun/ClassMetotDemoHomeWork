using System;

namespace ClassMetotDemoHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriClass musteri1 = new MusteriClass();
            musteri1.AdSoyad = "Zahid Gün";
            musteri1.TcKimlikNo = 1000000000;
            musteri1.Id = 1;
            musteri1.TelefonNo = 533000000;
            musteri1.Adres = "Ankara Çankaya";

            MusteriClass musteri2 = new MusteriClass();
            musteri2.AdSoyad = "Peri Gün";
            musteri2.TcKimlikNo = 2000000000;
            musteri2.Id = 2;
            musteri2.TelefonNo = 533000000;
            musteri2.Adres = "Diyarbakır Bağlar";

            MusteriClass musteri3 = new MusteriClass();
            musteri3.AdSoyad = "Metin Gün";
            musteri3.TcKimlikNo = 1000000000;
            musteri3.Id = 3;
            musteri3.TelefonNo = 533000000;
            musteri3.Adres = "Batman Merkez";

            MusteriClass musteri4 = new MusteriClass();
            musteri4.AdSoyad = "Hamza Gün";
            musteri4.TcKimlikNo = 1000000000;
            musteri4.Id = 4;
            musteri4.TelefonNo = 533000000;
            musteri4.Adres = "İzmir Karşıyaka";

            MusteriClass musteri5 = new MusteriClass();
            musteri5.AdSoyad = "Latif Gün";
            musteri5.TcKimlikNo = 1000000000;
            musteri5.Id = 5;
            musteri5.TelefonNo = 533000000;
            musteri5.Adres = "Ankara Etimesgut";

            MusteriClass musteri6 = new MusteriClass();
            musteri6.AdSoyad = "Rabia Gün";
            musteri6.TcKimlikNo = 1000000000;
            musteri6.Id = 6;
            musteri6.TelefonNo = 533000000;
            musteri6.Adres = "İstanbul Beylikdüzü";


            MusteriClass[] musteriClass = new MusteriClass[] {musteri1, musteri2, musteri3, musteri4, musteri5, musteri6 };

            foreach (MusteriClass musteri  in musteriClass )
            {
                Console.WriteLine("-------------Bankaya Kayıtlı Müşteri--------------");
                Console.WriteLine(musteri.AdSoyad);
                Console.WriteLine(musteri.TcKimlikNo);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.TelefonNo);
                Console.WriteLine(musteri.Adres);
                
            }

            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Ekle(musteri1);
            musteriMenager.Ekle(musteri2);
            musteriMenager.Ekle(musteri3);
            musteriMenager.Ekle(musteri4);
            musteriMenager.Ekle(musteri5);
            musteriMenager.Ekle(musteri6);

            Console.WriteLine("----------Hesabını Askıya Aldıran Müşteriler-----------");
            musteriMenager.Sil(musteri4);
            musteriMenager.Sil(musteri3);






        }
    }
}

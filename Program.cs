using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Tc = 98765432121;
            musteri1.Ad = "Merve";
            musteri1.Soyad = "ALKAN";
            musteri1.Cinsiyet = "Kadın";
            musteri1.Yas = 23;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Tc = 12345678920;
            musteri2.Ad = "Aylin";
            musteri2.Soyad = "ARANCAK";
            musteri2.Cinsiyet = "Kız";
            musteri2.Yas = 23;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("---------Müşteri Listesi---------");
            foreach (var musterilers in musteriler)
            {
                musteriManager.Listele(musterilers);
            }
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            Console.ReadLine();


        }
    }
}
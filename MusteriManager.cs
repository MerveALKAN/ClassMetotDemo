using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|" + musteri.Id + " : " + musteri.Ad + " " + musteri.Soyad + " Yeni Müşteri Eklendi!!!");
            Console.WriteLine("--------------------------------");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("| TC : " + musteri.Tc);
            Console.WriteLine("| Ad : " + musteri.Ad);
            Console.WriteLine("| Soyad : " + musteri.Soyad);
            Console.WriteLine("| Cinsiyet : " + musteri.Cinsiyet);
            Console.WriteLine("| Yaş : " + musteri.Yas);
            Console.WriteLine("--------------------------------");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|" + musteri.Id + " : " + musteri.Ad + " " + musteri.Soyad + " Müşteri Silindi!!!");
            Console.WriteLine("--------------------------------");

        }

    }
}


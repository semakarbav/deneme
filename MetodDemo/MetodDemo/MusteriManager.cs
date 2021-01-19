using System;
using System.Collections.Generic;
using System.Text;

namespace MetodDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)

        {
            Console.WriteLine("MusteriEkle Çalışıyor...");
            Console.WriteLine("Müşteri Adı : "+musteri.musteriAd);
            Console.WriteLine("Müşteri Soyadı : " + musteri.musteriSoyad);
            Console.WriteLine("Müşteri Tl Hesabına sahip mi : " + musteri.TLhesabıMı);

        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("MusteriListele Çalışıyor...");
            Console.WriteLine("Müşteri Adı : " + musteri.musteriAd);
            Console.WriteLine("Müşteri Soyadı : " + musteri.musteriSoyad);
            Console.WriteLine("Müşteri Tl Hesabına sahip mi : " + musteri.TLhesabıMı);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("MusteriSil Çalışıyor...");
            Console.WriteLine("Müşteri Adı : " + musteri.musteriAd);
            Console.WriteLine("Müşteri Soyadı : " + musteri.musteriSoyad);
            Console.WriteLine("Müşteri Tl Hesabına sahip mi : " + musteri.TLhesabıMı);
        }
    }
}

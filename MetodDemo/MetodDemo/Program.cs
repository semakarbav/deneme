using System;

namespace MetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriAd = "Ahmet";
            musteri1.musteriSoyad = "Çınar";
            musteri1.TLhesabıMı = true;

            Musteri musteri2 = new Musteri();
            musteri2.musteriAd = "Veli";
            musteri2.musteriSoyad = "Yılmaz";
            musteri2.TLhesabıMı = false;

            Musteri musteri3 = new Musteri();
            musteri3.musteriAd = "Ayşe";
            musteri3.musteriSoyad = "Görmez";
            musteri3.TLhesabıMı = true;


            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkle(musteri1);
            musterimanager.MusteriEkle(musteri2);
            musterimanager.MusteriEkle(musteri3);

            musterimanager.MusteriListele(musteri1);
            musterimanager.MusteriListele(musteri2);
            musterimanager.MusteriListele(musteri3);


            musterimanager.MusteriSil(musteri1);
            musterimanager.MusteriSil(musteri2);
            musterimanager.MusteriSil(musteri3);
        }
    }
}

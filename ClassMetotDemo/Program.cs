using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Yasin";
            musteri1.Soyadi = "Kahraman";
            musteri1.Id = 1;
            musteri1.HesapNumarasi = 2015141066;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Husne";
            musteri2.Soyadi = "Kahraman";
            musteri2.Id = 2;
            musteri2.HesapNumarasi = 2015141067;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Nihat";
            musteri3.Soyadi = "Kahraman";
            musteri3.Id = 3;
            musteri3.HesapNumarasi = 2015141068;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("------MÜŞTERİ BİLGİLERİ------");
                Console.WriteLine("MÜŞTERİ ADI :" + musteri.Adi);
                Console.WriteLine("MÜŞTERİ SOYADI :" + musteri.Soyadi);
                Console.WriteLine("MÜŞTERİ ID :" + musteri.Id);
                Console.WriteLine("MÜŞTERİ HesNo :" + musteri.HesapNumarasi);
                Console.WriteLine("-------------********************-------------");
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle("Ahmet", "Şafak", 2, 2015141055);
            musteriManager.MusteriGuncelle(musteri1);
            musteriManager.MusteriSil(musteri2);

        }
    }
}

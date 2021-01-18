using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(string musteriAdi, string soyadı, int id, int hesapNo)
        {
            Console.WriteLine("Tebrikler Müşteri Eklendi :" + " " + musteriAdi);
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Güncellendi : " + musteri.Adi);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Silindi : " + musteri.Adi);
        }
    }
}

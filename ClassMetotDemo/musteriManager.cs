using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri eklendi :" + musteri.Adi, musteri.Soyadi);
        } 

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " isimli müşteri silindi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("----MÜŞTERİ LİSTESİ----");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Adres);
                Console.WriteLine(musteri.Telefonu);
                Console.WriteLine("************");

            }
        }
    }
}

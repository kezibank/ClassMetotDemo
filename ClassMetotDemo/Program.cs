// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Console.WriteLine("Hello, World!");

Musteri musteri1 = new Musteri();
musteri1.Adi = "Keziban";
musteri1.Soyadi = "Karabaş";
musteri1.Adres = "Küçükçekmece/İstanbul";
musteri1.Telefonu = "0543 932 86 73";

Musteri musteri2 = new Musteri();
musteri2.Adi = "Ramazan";
musteri2.Soyadi = "Keskin";
musteri2.Adres = "Küçükçekmece/İstanbul";
musteri2.Telefonu = "0543 932 86 74";

Musteri musteri3 = new Musteri();
musteri3.Adi = "Serpil";
musteri3.Soyadi = "Karabaş";
musteri3.Adres = "Alanya/Antalya";
musteri3.Telefonu = "0543 932 86 75";

Musteri musteri4 = new Musteri();
musteri4.Adi = "Zekine";
musteri4.Soyadi = "Karabaş";
musteri4.Adres = "Zile/Tokat";
musteri4.Telefonu = "0543 932 86 63";

Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

//foreach (var musteri in musteriler)
//{
//    Console.WriteLine(musteri.Adi);
//    Console.WriteLine(musteri.Soyadi);
//    Console.WriteLine(musteri.Adres);
//    Console.WriteLine(musteri.Telefonu);
//    Console.WriteLine("************");
//}
MusteriManager musteriManager = new MusteriManager();   
musteriManager.Ekle(musteri1);
Console.WriteLine("----------");
musteriManager.Sil(musteri2);

musteriManager.Listele(musteriler);
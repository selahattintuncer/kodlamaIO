using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();

            //musteri1.Id = 1;
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.TcNo = "22222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            //Gerçek Müşteri - Tüzel Müşteri ==> ikiside müsteridir ama farklı özelliklerdedir. Örneğin TcNo ve VergiNo gibi.
            //Bunu düzeltmek için teknik kullanılır. Bu yüzden bu isimlerde iki farklı class oluşturuldu.

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "22222222";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama IO";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();         //Burada değişken tip class'ın Musteri olduğuna dikkart et_
                                                            //Sağ taraf new GercekMusteri ya da TuzelMusteri iken_
                                                            //sol taraf Musteri class ı olabiliyor... Yani olay  Temel sınıfın (ebeveyn) onu inherid eden alt sınıfın (evlat) referansını tutabilmesidir.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri3);








        }
    }
}

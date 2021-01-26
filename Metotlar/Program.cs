using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Kapuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi );
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("------------Metodler---------------");

            SepetManager sepetManager = new SepetManager();
            
            sepetManager.Ekle(urun1);  // bu yöntem daha kullanışlıdır. Urun.cs de urünler tanımlanmakta..
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Elma", "Amasya Elması", 12, 8); // bu yöntem kullanışsızdır. Ürünler burada parantez içinde tanımlanmakta
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 7); 
        }
    }
}

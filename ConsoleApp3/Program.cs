using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string katagoriEtiketi = "Kategori";
            int ogreciSayısı = 35000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun) 
            {
                Console.WriteLine("Azalış etiketi");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış etiketi");
            }
            else
            {
                Console.WriteLine("Çizgi etiketi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
            Console.WriteLine(katagoriEtiketi);
            
        }

    }
}

using System;
using System.Collections.Generic; // List koleksiyonunu ilk yazdığımızda yoktu. Hata verince ampüle basılarak eklendi.

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat", "Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //Console.WriteLine(isimler[3]);      // isimler dizisindeki dördüncü elemanı yazdırır.

            
            //*************Alternatif yöntem (koleksiyon)= ****************
            
            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };  // Arrey'e alternatif olarak_ 
                                                                                                // kullanılır. Koleksiyon olarak tanımlanır.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("ilker");              // Dört elemanı olan isimler2 isimli list değişkenine 5 inci elaman tanımladı ve_
                                                // ilker ismini atadı. Arreylerde bu şekilde yapmak mümkün değil.
            
            Console.WriteLine(isimler2[3]); 

        }
    }
}

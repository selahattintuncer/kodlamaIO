using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Tanımlama yöntemi, Product tipinde product1 adında değişken tanımlanıyor.
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // 2. Tanımlama yöntemi
            Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5, UnitPrice=35, ProductName="Kalem" };

            ProductManager productManager = new ProductManager();   // class  isimlendirmede ilk harfler büyüktür (PascalCase), 
                                                                    //değişkenlerde ise ilk kelimenin baş harfi küçük diğerleri büyüktür (camelCase). 
                                                                    // new ProductManager()= yeni referans numarası almış anlamında kullanılmıştır.
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);

            
            
            //for (int i = 1; i <= 10; i++) 
            //{
            //    int toplamSonuc = productManager.Topla3(i, i*10);   // ProductManager classında tanımlanan_
            //                                                        // Topla3 isimli metodu çağırıp içerisindeki sayi1'e_
            //                                                        // ve sayi2 ye for döngüsü ile değer atayıp, bu değerlerin_
            //                                                        // yine aynı class da return satırı ile yapılan çarpma_
            //                                                        // işleminin sonucunu bu satırda tanımlamış olduğumuz_
            //                                                        // toplamSonuc isimli değişkene atıyor ve onu da consolda_
            //                                                        // yazdırıyoruz.
            //    Console.WriteLine(toplamSonuc * 10);
            //}
            



             

        }
    }
}

using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Tanımlama yöntemi
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // 2. Tanımlama yöntemi
            Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5, UnitPrice=35, ProductName="Kalem" };

            ProductManager productManager = new ProductManager();  // class  isimlendirmede ilk harfler büyüktür, değişkenlerde ise ilk kelimenin baş harfi küçük diğerleri büyüktür. new ProductManager()= yeni referans numarası almış anlamında
            productManager.Add(product1);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // **Operasyonların yazıldığı class dır. **
    {
        public void Add(Product product)    // **ekleme operasyonu (metodu)dur. 
                                            //Product tipinde product isimli ürün ekle demektir.
                                            // * metodun nasıl çağrılacağının yazılı olduğu kod satırıdır.
                                            // * (Product product) = bana Product tipinde bir şey gönder, 
                                            // ben onu prodoct isimli değişkende tutuyor olacağım demektir. 
                                            //Bunu da Program.cs ye gönderir. 
        {
            Console.WriteLine(product.ProductName + "eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }

        //public int Topla3(int sayi1, int sayi2)
        //{
        //    return sayi1 * sayi2;
        //}


    }
}

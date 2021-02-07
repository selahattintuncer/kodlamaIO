using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product       // Özelliklerin yazılı olduğu class dır. 
                        // Entity diye adlandırılan varlıkların özellikleri bu class a yazılır. 
                        // Bu class da operasyonlar bulunmaz.
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }  //ürün katagorisi
        public string ProductName { get; set; } //ürün adı
        public double UnitPrice { get; set; }  // birim fiyatı
        public int UnitsInStock { get; set; } //stok miktarı

    }
}

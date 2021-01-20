using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product  //Entity-varlık
    {   //snippet
        public int Id { get; set; } //primary key

        public int CategoryId { get; set; } //referans anahtar hangi kategoriye ait ürün

        public string ProductName { get; set; }
        public double UnitPrice { get; set; } // ürün fiyatı
        public int UnitInStock { get; set; }  //stokadedi
    }
}

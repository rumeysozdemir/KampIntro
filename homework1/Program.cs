using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductGender = "Kadın";
            product1.ProductCategori = "Elbise";
            product1.ProductBrand = "Mango";
            product1.ProductPrice = 250;
            product1.ProductSize = 38;
            product1.ProductColor = "Beyaz";
            product1.ProductMaterial = "Pamuk";

            Product product2 = new Product();
            product2.ProductGender = "Kadın";
            product2.ProductCategori = "Gömlek";
            product2.ProductBrand = "Mavi";
            product2.ProductPrice = 180;
            product2.ProductSize = 36;
            product2.ProductColor = "Siyah";
            product2.ProductMaterial = "Pamuk";


            Product product3 = new Product();
            product3.ProductGender = "Erkek";
            product3.ProductCategori = "Pantolon";
            product3.ProductBrand = "Beymen";
            product3.ProductPrice = 450;
            product3.ProductSize = 42;
            product3.ProductColor = "Mavi";
            product3.ProductMaterial = "Kot";

            Product[] products = new Product[] { product1, product2, product3 };
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Cinsiyet:" + products[i].ProductGender + " Kategori:" + products[i].ProductCategori + " Marka:" + products[i].ProductBrand + " Fiyat:" + products[i].ProductPrice + " Beden:" + products[i].ProductSize + " Renk:" + products[i].ProductColor + " Materyal:" + products[i].ProductMaterial);

            }
            Console.WriteLine("for bitti");
            foreach (var product in products)
            {
                Console.WriteLine("Cinsiyet:" + product.ProductGender + " Kategori:" + product.ProductCategori + " Marka:" + product.ProductBrand + " Fiyat:" + product.ProductPrice + " Beden:" + product.ProductSize + " Renk:" + product.ProductColor + " Materyal:" + product.ProductMaterial);
            }
            Console.WriteLine("foreach bitti");

            int sayac = 0;
            while (sayac < products.Length)
            {
                Console.WriteLine("Cinsiyet:" + products[sayac].ProductGender + " Kategori:" + products[sayac].ProductCategori + " Marka:" + products[sayac].ProductBrand + " Fiyat:" + products[sayac].ProductPrice + " Beden:" + products[sayac].ProductSize + " Renk:" + products[sayac].ProductColor + " Materyal:" + products[sayac].ProductMaterial);
                sayac++;
            }
            Console.WriteLine("while bitti");
        }
    }








    class Product
    {
        public string ProductGender { get; set; }
        public string ProductCategori { get; set; }
        public string ProductBrand { get; set; }
        public int ProductPrice { get; set; }
        public int ProductSize { get; set; }
        public string ProductColor { get; set; }
        public string ProductMaterial { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //beni kullanabilmen için topla fonk cağırabilmen için 2 sayı vermen lazım
        //Topla(2,3) sayi1=2 sayi2=3 int toplam = 5 demek
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}

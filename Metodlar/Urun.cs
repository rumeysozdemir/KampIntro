using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Urun
    {
        //Property - Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyatı { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
        //hicbir sayfa patlamadı program.cs de buna encapsulation(kapsülleme) denir. ekle 2 de stok adedi deyince patladı tek tek ekledik.

    }   
}

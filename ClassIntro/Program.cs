using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           // string adi = "Engin";
            //int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "Java";
            kurs1.Egitmen = "Kerem";
            kurs1.IzlenmeOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Python";
            kurs2.Egitmen = "Berkay";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "C#";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 68;

            // Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmen);

            }

           // Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }

        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

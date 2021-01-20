using System;

namespace refandout
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref kullanımı
            int number1 = 10;
            int number2 = 20;
            var result = Add(ref number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            //out kullanımı
            string name1;
            string name2 = "Arda";
            var result2 = Read(out name1, name2);
            Console.WriteLine(result2);
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            //değer tip kullanımı

            int number3 = 70;
            int number4 = 60;
            var result3 = Sub(number3, number4);
            Console.WriteLine(result3);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
        }
        static int Sub(int number3, int number4)
        {
            number3 = 80;
            return number3 - number4;
        }
        static string Read(out string name1, string name2)
        {
            name1 = "Beyza";
            return name1 + name2;

        }
        static int Add(ref int number1, int number2)
        {

            number1 = 50;
            return number1 + number2;
        }
    }
}

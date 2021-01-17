using System;

namespace refUse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 50;
            var result = Divide(number1, number2);

            Console.WriteLine("Sonuç : " + result);
            //Console.WriteLine("Main'deki number1 : " + number1);
            Console.ReadLine();
        }

        static int Divide(int number1, int number2)
        {
            number1 = 5;  // yazmak zorunda değiliz fakat değer değişimi görmek için yazdım.
            //Console.WriteLine("Method'daki number1 : " + number1);
            return number2 / number1;
        }
    }
}

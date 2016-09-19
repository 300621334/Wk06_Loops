using System;
/*10.	A conversion table of Celsius to Fahrenheit temperature. The table must start with 0 Celsius and end at 100 Celsius with increments of 10. (Fahrenheit = Celsius * 9/5 + 32)*/
namespace _06._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int cel = 0, celStop = 100, increment=10, fah;
            Console.WriteLine("Celcius---Fahrenheit\n=======   ==========");

            do
            {
                fah = cel * 9 / 5 + 32;
                //Console.WriteLine("Celcius = {0, 3}---Fahrenheit = {1, 3}", cel, fah);
                Console.WriteLine("{0, 7}---{1}", cel, fah);
                cel = cel + increment;
            }
            while(cel<=celStop);
          

        }
    }
}

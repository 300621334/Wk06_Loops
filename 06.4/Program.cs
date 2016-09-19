using System;
/*4.	To display the numbers 1 … 20 on separate lines with an asterisk next to multiples of 5. (multiples besides asterisk) */
namespace _06._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                if (counter % 5 == 0)
                {
                    Console.WriteLine(counter+"*");
                }
                else if (counter % 5 != 0)
                {
                    Console.WriteLine(counter+"");
                }
                counter = counter + 1;
            }
            while (counter <= 20);
        }
    }
}

using System;
/*3.	To display the numbers 1 … 20 on separate lines*/

namespace _06._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }
            while (counter <= 20);
        }
    }
}

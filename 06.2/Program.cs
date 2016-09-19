using System;
/*2.	To display the numbers 1 … 5 on separate lines*/

namespace _06._2
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
            while(counter <= 5);

        }
    }
}

using System;
/*6.	To display numbers 20 … 60 on separate lines skipping the multiple of 3. 
 * You must print a blank line for each multiple.*/

namespace _06._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 20, stop=60;

            do
            {
                if (start % 3 == 0)
                {
                    Console.WriteLine(" ");
                }
                else if (start % 3 != 0)
                {
                    Console.WriteLine("" + start);

                }
                start = start + 1;
            }
            while (start <= stop);
        }
    }
}

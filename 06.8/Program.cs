using System;
/*
8.	Same as the previous question but additionally displays the average of the numbers at the end of the loop. You will need a 
counter but not as a loop terminator.
*/

namespace _06._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, counter = 0, average;

            do
            {
                Console.WriteLine("Enter a number: ");
                num += Convert.ToInt32(Console.ReadLine());
                counter = counter + 1;
            }
            while (num <= 100);
            average = num / counter;
            //Console.WriteLine("You made {0} entries, total of which is {1}\nand average is {2} ", counter, num, average);
            Console.WriteLine("Total entries made = {0}", counter);
            Console.WriteLine("Sum of all entries = {0}", num);
            Console.WriteLine("Average of entries = {0}", average);

        }
    }
}

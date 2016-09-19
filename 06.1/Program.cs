using System;
/*1.To display five asterisks on a single line. Each asterisk must be separated by a space. 
 * You must use a do-while loop to solve this program*/

namespace _06._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            do
            {
                Console.Write("* ");
                counter = counter + 1;
            }
            while(counter <5);


        }
    }
}

using System;
/*7.To repeatedly prompt for a number and sum it. When the sum just exceeds 100, stop the prompting and display the sum at the end. 
 *  You must not display the sum while the user in typing in numbers. 
 (You do not need a counter but you will need some way of terminating the loop)*/

namespace _06._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =0;

            do
            {
                Console.WriteLine("Enter a number: ");
                num += Convert.ToInt32(Console.ReadLine());
                
            }
            while(num<=100);

            Console.WriteLine("Sum of numbers you entered is {0}",num);
            
        }
    }
}

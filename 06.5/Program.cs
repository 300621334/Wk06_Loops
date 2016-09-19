using System;
/*5.	To display the numbers 10 … 40 on separate lines with an asterisk before the multiples of 7. (asterisk besides multiples)*/

namespace _06._5
{
    class Program
    {
        static void Main(string[] args)
        {

            int start=10;

            do
            {
                if (start % 7 == 0)
                {
                    Console.WriteLine("*"+start);
                }
                else if (start % 7 != 0)
                {
                    Console.WriteLine(""+start);

                }
                start = start+1;
            }
            while (start <=40);
        }
    }
}

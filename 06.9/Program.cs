using System;
/*9.	To display the sum of all the multiples of 3 between 1000000 and 2000000. 
(Answer = 499, 999, 500, 000). If the sum might be larger than 2billion then the type of sum should be a long and not an int.
*/

namespace _06._9
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0, start=1000000, stop=2000000;

            do
            {
                if(start%3==0)
                {
                    sum = start + sum;
                }

                start = start + 1;
            }
            while(start<stop);

            Console.WriteLine("{0:n0}",sum);

        }
    }
}

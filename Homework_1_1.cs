using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Course_Part_1
{
    class Homework11
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer to check");
                int n = Convert.ToInt32(Console.ReadLine());
                int d = 0;
                int i = 2;
                int result = simpleNumberCheck(n, d, i);
            }
        }
        
    static int simpleNumberCheck(int numberToCheck, int confirmationNumber, int dividend)
        {
            while (dividend < numberToCheck)
            {
                var result = numberToCheck % dividend;
                if (result == 0)
                {
                    confirmationNumber++;
                    dividend++;
                }
                else
                {
                    dividend++;
                }
            }
            if (confirmationNumber == 0)
            {
                Console.WriteLine("The number is simple");
            }
            else
            {
                Console.WriteLine("The number is not simple");
            }
            return 0;
        }
    }

}

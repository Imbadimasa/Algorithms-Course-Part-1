using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Course_Part_1
{
    class Homework22
    {
        public void Run()
        {

            int[] myArray = new int[51];
            int input = 40;


            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
                Console.WriteLine(myArray[i]);
            }


            int result = myArray[15];
            int min = myArray[0];
            int max = myArray[49];

            while (input != result)
            {
                int mid = (min + max) / 2;
                if (mid == input)
                {
                    break;
                }
                else if (mid > input)
                {
                    max = mid;
                }
                else if (mid < input)
                {
                    min = mid;
                }
            }
            Console.WriteLine("Success!");
        }
    }
}



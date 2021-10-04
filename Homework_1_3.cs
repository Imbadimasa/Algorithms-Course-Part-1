using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Course_Part_1
{
    class Homework13
    {
        public void Run()
        {
            int n = 10;
            Console.WriteLine(FibonacciRecursion(n));
            Console.WriteLine(FibonnacciLoop(n));
        }

        private int FibonnacciLoop(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        private int FibonacciRecursion(int n)
        {
            if (n == 1||n==2)
            {
                return 1;
            }
            return (FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2));
        }
    }

}

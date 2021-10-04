using System;

namespace Algorithms_Course_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a Homework to run.");
            var input = Convert.ToInt32(Console.ReadLine());
            
            if (input == 1)
            {
                Homework11 Homework_11 = new Homework11();
                Homework_11.Run();
            }
            else if (input == 2)
            {
                Homework12 Homework_12 = new Homework12();
                Homework_12.Run();
            }
            else if (input == 2)
            {
                Homework12 Homework_12 = new Homework12();
                Homework_12.Run();
            }
        }
    }
}

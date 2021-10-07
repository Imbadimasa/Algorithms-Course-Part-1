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
                Homework21 Homework_21 = new Homework21();
                Homework_21.Run();
            }
            else if (input == 2)
            {
                Homework22 Homework_22 = new Homework22();
                Homework_22.Run();
            }
        }
        
    }
}

using System;

namespace Day1assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter Your Age :");
            var ageString = Console.ReadLine();
            int MyAge ;

            bool parseSuccess = int.TryParse(ageString, out MyAge);

            if (parseSuccess)
                Console.WriteLine($"Your age is: {MyAge}");
            else
                Console.WriteLine("This is not a number!");
            
            Console.WriteLine("Enter Your Name :");
            String MyName = Console.ReadLine();
            Console.WriteLine($"Your  name is {MyName} and your age is {MyAge}");
        }
    }
}

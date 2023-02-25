using System;

namespace Programdotne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value of the first angle: ");
            double angle1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value for the second number: ");
            double angle2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value for the third angle: ");
            double angle3 = double.Parse(Console.ReadLine());
            dobule result = angle1 +angle2 +angle3;

            if (result = 180)
            {
                Console.WriteLine("Congrats. With this angles you can build a triangle!");
            }
            else
            {
                Console.WriteLine("I'm sorry, with this angles you cannot build a triangle!");
            }
        }
    }
}
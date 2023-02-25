using System;
public class Calculator
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter another number: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("What operation do you want to make: ");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "multiply":
                Console.WriteLine(number1 * number2);
                break;
            case "divide":
                Console.WriteLine(number1 / number2);
                break;
            case "add":
                Console.WriteLine(number1 +number2);
                break;
            case "extract":
                Console.WriteLine(number1 - number2);
                break;
            case "power":
                Console.WriteLine(Math.Pow(number1, number2));
                break;
            case "modulo":
                Console.WriteLine(number1 % number2);
                break;
            default:
                System.Console.WriteLine("You entered a wrong input.");
                break;
        }
    }
}
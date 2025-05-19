using System;
public class Calculator
{
    static double add(double a, double b)
    {
        return a + b;
    }
    static double subtract(double a, double b)
    {
        return a - b;
    }
    static double multiply(double a, double b)
    {
        return a * b;
    }
    static double divide(double a, double b)
    {
        return a / b;
    }
    static void Main()
    {
        bool exit = false;
        while(!exit)
        {
        Console.WriteLine("Calculator Menu");
        Console.WriteLine("1. Addition ");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit");
        Console.WriteLine("Please select the operation to perform (1-5)");
        string selectOption = Console.ReadLine();
        
        switch(selectOption)
        {
            case "1":
            Addition();
            break;
            
            case "2":
            Subtraction();
            break;
            
            case "3":
            Multiplication();
            break;
            
            case "4":
            Division();
            break;
            
            case "5":
            exit=true;
            break;
            
            default:
            Console.WriteLine("Invalid input Please Try again (1-5");
            break;
        }
        static void Addition()
        {
            Console.WriteLine("Addition");
            Console.WriteLine("Enter the first number");
            double add1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Enter the second number");
            double add2 = double.Parse(Console.ReadLine());
            double addition = add(add1, add2);
            Console.WriteLine("The result is "+addition);
        }
        static void Subtraction()
        {
            Console.WriteLine("Subtraction");
            Console.WriteLine("Enter the first number");
            double subtract1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Enter the second number");
            double subtract2 = double.Parse(Console.ReadLine());
            double subtraction = subtract(subtract1, subtract2);
            Console.WriteLine("The result is "+subtraction);
        }
        static void Multiplication()
        {
            Console.WriteLine("Multiplication");
            Console.WriteLine("Enter the first number");
            double multiply1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Enter the second number");
            double multiply2 = double.Parse(Console.ReadLine());
            double multiplication = multiply(multiply1, multiply2) ;
            Console.WriteLine("The result is "+multiplication);
        }
        static void Division()
        {
            Console.WriteLine("Division");
            Console.WriteLine("Enter the first number");
            double numerator = double.Parse(Console.ReadLine());
             Console.WriteLine("Enter the second number");
            double denominator = double.Parse(Console.ReadLine());
            double division = divide(numerator, denominator) ;
                if (denominator == 0)
                {
                    Console.WriteLine("The operation is invalid");
                }
                else
                {
                    Console.WriteLine("The result is "+division);
                }
        }
    }
}
}
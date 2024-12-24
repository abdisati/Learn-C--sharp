using System;

namespace calculator_program {
    class Program{

static void Main(string[] args){
    double num1 = 0;
    double num2 = 0;
    double result = 0;



    Console.WriteLine("--------------------");
    Console.WriteLine("Calculator Program");
    Console.WriteLine("--------------------");

    do{
    Console.Write("Enter number 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter number 2: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the operation: ");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Substract");
    Console.WriteLine("\t* : Multiply");
    Console.WriteLine("\t/ : Divide");

    switch(Console.ReadLine()){
        case "+":
        result = num1 + num2;
        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
        break;
        case "-":
        result = num1 - num2;
        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
        break;
        case "*":   
        result = num1 * num2;
        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
        break;
        case "/":   
        result = num1 / num2;   
        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
        break;
        default:
        Console.WriteLine("Invalid operation");
        break;
    }
    Console.WriteLine("Do you want to perform another operation? (y/n)");
    } while(Console.ReadLine().ToLower() == "y" );
    Console.WriteLine("Thank you for using the calculator program");

}

    }
}
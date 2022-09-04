using ConsoleTables;

// See https://aka.ms/new-console-template for more information

// #1 print the output of adding two numbers from user input
Console.WriteLine("Hello!");

int num1, num2;
Console.Write("Enter the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} + {num2} = {num1 + num2}");


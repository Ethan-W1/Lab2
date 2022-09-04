using ConsoleTables;

// #4 Calculator
string operation;


for (; ; )
{
    Console.Write("Enter your first number: ");
    num1 = Convert.ToInt32((Console.ReadLine()));

    Console.Write($"Enter your operation +, -, *, /, % \n if you want to exit, type 'exit' ");
    operation = Console.ReadLine();
    if (operation == "exit")
    {
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }


    Console.Write("Enter your second number: "); ;
    num2 = Convert.ToInt32((Console.ReadLine()));


    if (operation == "+")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 + num2));
    }
    else if (operation == "-")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 - num2));
    }
    else if (operation == "*")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 * num2));
    }
    else if (operation == "/")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 / num2));
    }
    else if (operation == "%")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 % num2));
    }
}
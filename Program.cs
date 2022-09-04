using ConsoleTables;

// #3 Output the number of bytes in memory

ConsoleTable table = new ConsoleTable("Type", "Byte(s) of Memory", "Min", "Max");
table.AddRow("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
table.AddRow("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
table.AddRow("short", sizeof(short), short.MinValue, short.MaxValue);
table.AddRow("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
table.AddRow("int", sizeof(int), int.MinValue, int.MaxValue);
table.AddRow("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
table.AddRow("long", sizeof(long), long.MinValue, long.MaxValue);
table.AddRow("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
table.AddRow("float", sizeof(float), float.MinValue, float.MaxValue);
table.AddRow("double", sizeof(double), double.MinValue, double.MaxValue);
table.AddRow("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
Console.WriteLine(table);

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


using ConsoleTables;

// #2 Multiply table
int bigNumber;

Console.Write("Enter the number you like to use ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number you would like to use for the multiplication table:");
bigNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < bigNumber; i++)
{
    Console.WriteLine($"{num1} * {i} = {num1 * i}");
}
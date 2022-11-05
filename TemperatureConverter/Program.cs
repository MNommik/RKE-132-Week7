Console.WriteLine("Enter the operation (C/F)");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter degrees:");
int firstNum = Int32.Parse(Console.ReadLine());


switch (userOperator)
{
    case 'F':
        ConvertToFahrenheit(firstNum);
        break;
    case 'C':
        ConvertToCelsius(firstNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}


static void ConvertToFahrenheit(int a)
{
    Console.WriteLine($"{(a * 9) / 5+ 32}");
}
static void ConvertToCelsius(int a)
{
    Console.WriteLine($"{(a - 32) * 5 / 9}");
}

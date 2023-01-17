Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if ( a > b )
{
    System.Console.Write($"max {a}, min {b}");
}
if (b > a )
{
     System.Console.Write($"max {b}, min {a}");
}

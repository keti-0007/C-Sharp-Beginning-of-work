//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
System.Console.WriteLine("Введите число для проверки на четность: ");
int var = Convert.ToInt32(Console.ReadLine());

if (var%2==0)
{
    System.Console.WriteLine($"Число {var} четное!");
}
else
{
    System.Console.WriteLine($"Число {var} нечетное!");
}


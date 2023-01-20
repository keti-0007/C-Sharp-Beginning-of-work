//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// не доваблена и не коммичена.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) > 99)
{
    while (Math.Abs(number) >999)
    {
        number = number / 10;

    }
    number = Math.Abs(number % 10); 
    System.Console.WriteLine($"Третья цифра {number}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
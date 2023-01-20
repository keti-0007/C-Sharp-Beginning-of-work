
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер(от 1 до 7) дня недели:");
 int day = Convert.ToInt32(Console.ReadLine());

 while (day < 1 || day > 7);

switch (day) 
{
case 6:
case 7:
Console.WriteLine("Выходной");
break;

default:
Console.WriteLine("Рабочий день");
break;
}





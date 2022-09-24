// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());
string numberStr = Convert.ToString(a);

if (numberStr.Length > 2)
{
    Console.WriteLine($"{numberStr[2]} -> третья цифра");
}
else
{
    Console.WriteLine($"в числе {numberStr} -> третьей цифры нет");
}

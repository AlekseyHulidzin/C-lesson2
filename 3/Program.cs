// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели ");
int weekDay = int.Parse(Console.ReadLine());

if (weekDay == 6 || weekDay == 7)
{
    Console.WriteLine($"{weekDay} - Сегодня выходной");
}
else if (weekDay > 7 || weekDay < 1)
{
    Console.WriteLine("Введите верные данные");
}
else
{
    Console.WriteLine($"{weekDay} - Еще рабочая неделя");
}
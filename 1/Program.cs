/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1  */


Console.WriteLine("Введите трехзначное число число");
string namberStr = Console.ReadLine();
int namber_lenght = namberStr.ToString().Length;//   длина чисел
int namber = int.Parse(namberStr);

int average_number = ((namber / 10) % 10);


if (namber_lenght > 3 || namber_lenght < 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine($"{average_number} - Это среднее значение");
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите трехзначное число");
string namber = Console.ReadLine();
int[] b = new int[namber.Length];




if (namber.Length == 3 )
{
    
    Console.WriteLine($"{namber[3]} ");

}
else if (namber.Length < 3)
{
    Console.WriteLine($" в числе {namber} нет третьей цифры ");
}

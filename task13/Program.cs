// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    if (number < 1000)
    {
        int three = number % 100;
        int tow = three % 10;
        Console.Write(tow);
    }
}


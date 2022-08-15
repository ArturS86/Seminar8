// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int quadro1 = Quadro(number1);
int quadro2 = Quadro(number2);

if (quadro1 == number2 || quadro2 == number1)
{
Console.Write("Да");
}
else 
{
  Console.Write("Нет");  
}

int Quadro (int a)
{
    return a * a;
}


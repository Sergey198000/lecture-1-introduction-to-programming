//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int stepNumber = 1;

if (number < 1)
{
    Console.WriteLine("Введите число больше 0");
    return;
}

while (stepNumber <= number)
{
    Console.WriteLine($"Cube of (stepNumber) is: " + stepNumber * stepNumber * stepNumber);
    stepNumber++;
}
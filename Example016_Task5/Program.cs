﻿Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write(count);
        Console.Write(", ");
    }
    count++;
}
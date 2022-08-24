Console.Clear();
Console.WriteLine("Введите число обозначающее день недели от 1 до 7: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 6 && n > 0)
{
    Console.WriteLine("Нет. Это будний день!");
}
else if (n > 5 && n <= 7)
{
    Console.WriteLine("Да. Это выходной день!");
}    
else
{
    Console.WriteLine("Введите число от 1 до 7. Такого дня недели нет!");
}
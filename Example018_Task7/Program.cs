Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if (n >= 100 || n < 1000)
{
    int a1 = n % 10;
    Console.Write(a1);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
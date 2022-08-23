Console.Clear();
Console.WriteLine("Введите число от 100 до 999: ");
int n = int.Parse(Console.ReadLine()!);

int a1 = n / 10;
int a2 = a1 % 10;

Console.Write(a2);
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()!);
string nText = Convert.ToString(n);

if (nText.Length > 2)
{
    Console.Write(nText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
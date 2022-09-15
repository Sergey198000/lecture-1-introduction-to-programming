// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i=3; i>=0; i--)
{
    sum+=number/(int)Math.Pow(10.0,i);
    number=number%(int)Math.Pow(10.0,i);
}
Console.WriteLine(sum);
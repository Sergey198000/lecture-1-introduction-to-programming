﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ира")
{
    Console.WriteLine("Ура, это же ИРА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
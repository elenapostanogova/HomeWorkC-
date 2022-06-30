/*
    Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

string message;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int talls = num % 2;

if (talls == 0)
{
    message = "четное";
}
else
{
   message = "не четное";
}
Console.WriteLine(num + " -> " + message);
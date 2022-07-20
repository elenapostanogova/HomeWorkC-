/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void IsPalindrome (int x)
{
    int x0 = x / 10000;
    int x1 = x / 1000 - x0 * 10;
    int x2 = x / 100 - x0 * 100 - x1 * 10;
    int x3 = x / 10 - x0 * 1000 - x1 * 100 - x2 * 10;
    int x4 = x % 10;

    if(x0 == x4 && x1 == x3)
        Console.WriteLine("Число " + x +" палиндром");
    else
        Console.WriteLine("Число " + x +" не палиндром");
}

Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
IsPalindrome (x);
﻿/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void OutputCubesNumbers(int value)
{
    for (int i = 1; i <= value; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
OutputCubesNumbers(x);
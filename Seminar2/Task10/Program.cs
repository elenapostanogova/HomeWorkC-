/*
    Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

void FindSecondDigit(int n)
{
    int cen = n / 100;
    int dec = n / 10 - cen * 10;
    int ed =  n % 10;
    string messageerror = "Ошибка, Вы ввели не трехзначное число";


    if (cen == 0) 
    {
        Console.WriteLine(messageerror);
    }
    else
    {
        if (cen > 10) 
        {
            Console.WriteLine(messageerror);
        }
        else
        {
            Console.WriteLine("Вторая цифра числа " + n + " равна " + dec);
        }
    }
};

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

FindSecondDigit(num);

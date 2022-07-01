/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
int orderdigit = 3;

int CalcCountDigit(int n)
{
    int div = n;
    int count = 1;

    while(div >= 10)
    {
        div = div / 10;
        count++;
    }
    return count;
};

void FindThirdDigit(int n)
{
    string messageerror = "Третьей цифры в числе нет";

    int div = n;
    int taills = 0;
    int index = 0;
    int countdiv = CalcCountDigit(n) - orderdigit + 1; 

    if(n < 100) 
    {
        Console.WriteLine(messageerror);
    }
    else 
    {
        while (index < countdiv)
        {
            taills = div % 10;
            div = div / 10;
            index++;
        }
        Console.WriteLine("Третья цифра числа " + n + " равна " +taills);
    }
};

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

FindThirdDigit(num);
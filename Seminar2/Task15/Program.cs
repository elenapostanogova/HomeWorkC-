/*
     Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

void DayIsWeekend(int n)
{
    string messageerror = "Введенное число не соответсвует ни одному номеру дня недели";
    if (n >= 1)
    {
        if (n <= 7)
        {
            if(n ==6)
            {
                Console.WriteLine("да");
            }
            else 
            {
                if (n == 7)
                {
                    Console.WriteLine("да");
                }
                else 
                {
                    Console.WriteLine("нет");
                }
            }
        }
    }
    else 
    {
        Console.WriteLine(messageerror);
    }
};

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

DayIsWeekend(num);
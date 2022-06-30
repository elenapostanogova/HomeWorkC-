/*
    Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a, min = a;
if (b > max)  
{
    max = b;
}
else  
{
    min = b;
};

Console.Write("a = " + a + ", b = " + b + " -> max = " + max + " , min = " + min);
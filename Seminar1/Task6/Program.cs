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
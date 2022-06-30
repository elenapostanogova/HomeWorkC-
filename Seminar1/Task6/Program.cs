int num, talls;
string message;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

talls = num % 2;

if (talls == 0)
{
    message = "четное";
}
else
{
   message = "не четное";
}
Console.WriteLine(num + " -> " + message);
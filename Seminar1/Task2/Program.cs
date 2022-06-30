int a, b, max;

Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

max = a;
if (b > max)  max = b;

Console.Write("a = " + a + ", b = " + b + " -> max = " + max);
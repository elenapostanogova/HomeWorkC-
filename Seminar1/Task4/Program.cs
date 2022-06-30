int a, b, c, max;

Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());

max = a;
if (b > max)  max = b;
if (c > max)  max = c;

Console.Write(a + ", " + b + ", " + c + " -> max = " + max);
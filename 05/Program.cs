// 5.С клавиатуры вводятся три числа. Найти максимальное из трех чисел.

System.Console.WriteLine("Введите три числа:");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());
if (a>b && a>c)
{
    System.Console.WriteLine($"Маскимальное число {a}");
}
if (c>a && c>b)
{
    System.Console.WriteLine($"Маскимальное число {c}");
}
if (b>a && b>c)
{
    System.Console.WriteLine($"Маскимальное число {b}");
}
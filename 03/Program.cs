// 3.С клавиатуры вводятся два числа a и b. Найти максимальное из них.
System.Console.Write("Введите число a: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    System.Console.WriteLine($"Число а={a} больше числа b={b}.");
}
if (a<b)
{
    System.Console.WriteLine($"Число b={b} больше числа a={a}.");
}
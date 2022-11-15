// 12.С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа.

System.Console.Write("Введите целое число от 10 до 99: ");
int a=Convert.ToInt32(Console.ReadLine());
int c=a/10;
System.Console.WriteLine(c);
int b=a%10;
System.Console.WriteLine(b);
if (c>b)
{
    System.Console.WriteLine($"Наибольшей цифрой числа {a} является {c}");
}
else
{
    System.Console.WriteLine($"Наибольшей цифрой числа {a} является {b}");
}
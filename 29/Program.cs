// 29.Подсчитать сумму цифр в числе. Сделать подпрограмму.

int SumOfDigits(int A)
{
int x=0;
while (A>99)
{
    x+=A%10;
    A=A/10;
}
x+=A/10+A%10;
return (x);
}

System.Console.Write("Введите число: ");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр числа= {SumOfDigits(A)}");

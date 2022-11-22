// 30.Написать программу вычисления произведения чисел от 1 до N

int i=1;
double a=1;
double proiz(int i)
{
    a=a*i;
    return a;
}

System.Console.Write("Введите число, до которого будет вычисляться произведение чисел: ");
int A=Convert.ToInt32(Console.ReadLine());
while(i<=A)
{
    a=proiz(i);
    i++;
}
System.Console.WriteLine($"Произведение чисел: {a}");
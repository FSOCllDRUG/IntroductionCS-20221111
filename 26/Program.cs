// 26. Сумму чисел от 1 до А
int i=1;
int a=0;
int sum(int i)
{
    a=a+i;
    return a;
}

System.Console.Write("Введите число, до которого будет вычисляться сумма чисел: ");
int A=Convert.ToInt32(Console.ReadLine());
while(i<=A)
{
    a=sum(i);
    i++;
}
System.Console.WriteLine($"Сумма чисел: {a}");
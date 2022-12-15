// 72.Показать натуральные числа от M до N, N и M заданы

void Natur(int N,int i)
{
    if (i<=N)
    {
        System.Console.Write($"{i} ");
        Natur(N,i+1);
    }    
}

System.Console.Write("Введите M: ");
int M=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите N: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=M;
Natur(N,i);
// 71.Показать натуральные числа от N до 1, N задано

void Natur(int N,int i)
{
    if (1<=i)
    {
        System.Console.Write($"{i} ");
        Natur(N,i-1);
    }    
}

System.Console.Write("Введите N: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=N;
Natur(N,i);
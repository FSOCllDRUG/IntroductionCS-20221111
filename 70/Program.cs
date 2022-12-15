//  70.Показать натуральные числа от 1 до N, N задано

void Natur(int N,int i)
{
    if (i<=N)
    {
        System.Console.Write($"{i} ");
        Natur(N,i+1);
    }    
}

int i=1;
System.Console.Write("Введите N: ");
int N=Convert.ToInt32(Console.ReadLine());
Natur(N,i);
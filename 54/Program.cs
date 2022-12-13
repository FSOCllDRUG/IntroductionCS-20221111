// 54.С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

int[] Fibonacci(int N)
{
    int[] a= new int [N];
    a[0]=0;
    a[1]=1;
    for(int i=2;i<N;i++) a[i]=a[i-1]+a[i-2];
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i]} ");
}

System.Console.Write("Введите значение N: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] a=Fibonacci(N);
Print(a);
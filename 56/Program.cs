// 56.Написать программу копирования массива

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max);
    return a;
}

int[] ArrayCopy(int[] a)
{
    int[] c=new int[a.Length];
    for(int i=0;i<c.Length;i++)
    c[i]=a[i];
    return c;
}
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

void СPrint(int[] с)
{
    for(int i=0;i<с.Length;i++)
        System.Console.Write($"{с[i],5}");
}

int[] a=RandomIntArray();
Print(a);
System.Console.WriteLine();
int[] c=ArrayCopy(a);
СPrint(c);
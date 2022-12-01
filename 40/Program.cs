// 40.Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве a.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int[] NewArray(int[] a,int halfN)
{
    int[] newA= new int[halfN];
    for(int i=0;i<halfN;i++)
    {
        {
            // while(i!=a.Length/2)
            newA[i]=a[i]*(a[(a.Length-1)-i]);
        }
    }
    return newA;
}

void HalfN(int N,out int halfN)
{
        halfN=N/2;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

void PrintNew(int[] newA)
{
    for(int i=0;i<newA.Length;i++)
        System.Console.Write($"{newA[i],5}");
}

System.Console.Write("Введите количество элементов начального массива: ");
int N=Convert.ToInt32(Console.ReadLine());
int halfN;
int[] a=RandomIntArray(N,1,10);
Print(a);
HalfN(N,out halfN);
System.Console.WriteLine();
int[] newA=NewArray(a,halfN);
PrintNew(newA);
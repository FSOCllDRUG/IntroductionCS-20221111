/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] Random2DArray(int n=4,int m=4,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

int MinLine(int[,] a)
{
    int summ=0;
    int temp=999;
    int min=0;
   for(int i=0;i<a.GetLength(1)-1;i++)
        {
        for(int j=0;j<a.GetLength(0)-1;j++)
        summ+=a[i,j];
        if(summ<temp) {min=i;temp=summ;summ=0;}
        }
    return min;
}

int[,] a= Random2DArray();
Print2DArray(a);
System.Console.WriteLine($"{MinLine(a)+1} строка");

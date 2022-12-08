// 67.Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] Random2DArray(int n,int k,int min=0,int max=10)
{
    int[,] a=new int[n,k];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<k;j++)
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

void Print(int[] avg)
{
    System.Console.WriteLine("Среднестатистическое значение чисел в столбцах соответственно:");
    for(int i=0;i<avg.Length;i++)
        System.Console.Write($"{avg[i],4}");
}

int[] AvgOfColumn(int[,] a)
{
   int[] avg=new int [a.GetLength(1)];
   for(int i=0;i<a.GetLength(0);i++)
        {
        for(int j=0;j<a.GetLength(1);j++)
        avg[j]+=a[i,j];
        }
    for(int i=0;i<avg.Length;i++)
        avg[i]=avg[i]/a.GetLength(0);
    return avg;
}

System.Console.Write("Введите значение n(кол-во строк): ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение k(кол-во столбцов): ");
int k=Convert.ToInt32(Console.ReadLine());
int[,] a=Random2DArray(n,k);
Print2DArray(a);
int[] avg=AvgOfColumn(a);
Print(avg);

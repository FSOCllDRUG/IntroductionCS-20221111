// 61.Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] Random2DArray(int n=5,int m=5,double min=1.1,double max=10.1)
{
    double[,] a=new double[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.NextDouble()* 5;
    return a;
}

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4:F2} ");
           System.Console.WriteLine();
        }
}
double[,] a=Random2DArray();
Print2DArray(a);

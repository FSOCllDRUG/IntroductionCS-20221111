// 62.В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
// Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

int[,] Random2DArray(int n,int k,int min=0,int max=10)
{
    int[,] a=new int[n,k];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<k;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(bool v,int[,] a)
{
    if (v==true) System.Console.WriteLine("Начальный двумерный массив:");
    else System.Console.WriteLine("Изменённый двумерный массив:");
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

int[,] Negative2DArray(int n,int k,int[,] a,ref bool v)
{
    for(int i=0;i<n;i++)
         for(int j=0;j<k;j++)
                a[i,j]=a[i,j]*-1;
    v=false;
    return a;
}
bool v=true;
System.Console.Write("Введите значение n(кол-во строк): ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение k(кол-во столбцов): ");
int k=Convert.ToInt32(Console.ReadLine());
int[,] a=Random2DArray(n,k);
Print2DArray(v,a);
a=Negative2DArray(n,k,a,ref v);
Print2DArray(v,a);
/*Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

int[,] Random2DArray(int n,int m,int min=0,int max=10)
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
        System.Console.Write($"{a[i,j],3}");
           System.Console.WriteLine();
        }
}
 
 
void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}
 
void SelectSort(int[,] a)
{
   int im;
   for(int l=0;l<a.GetLength(0);l++)
   {
        for(int i=0;i<a.GetLength(1);i++)
        {
                im=i;
                for(int j=i+1;j<a.GetLength(1);j++) if (a[l,im]<a[l,j]) im=j;
                Swap(ref a[l,i],ref a[l,im]);
        }
        // im=0;
   }
}
 
System.Console.Write("Введите значение n(кол-во строк): ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение k(кол-во столбцов): ");
int k=Convert.ToInt32(Console.ReadLine());
int[,] a= Random2DArray(n,k);
Print2DArray(a);
System.Console.WriteLine();
SelectSort(a);
Print2DArray(a);
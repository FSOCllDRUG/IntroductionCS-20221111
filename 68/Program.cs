// 68.Написать программу, которая обменивает элементы первой строки и последней строки

int[,] Random2DArray(int n,int k,int min=0,int max=10)
{
    int[,] a=new int[n,k];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<k;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

int[] Temp(int[,] a)
{
    int[] temp=new int[a.GetLength(1)];
    for(int i=0;i<a.GetLength(1);i++) temp[i]=a[0,i];
        return temp;
}
void Swap(ref int[,] a,int[] temp,ref bool v)
{
    for(int i=0;i<a.GetLength(1);i++) a[0,i]=a[a.GetLength(0)-1,i];
    for(int i=0;i<a.GetLength(1);i++) a[a.GetLength(0)-1,i]=temp[i];
    v=false;
}
void Print2DArray(int[,] a,bool v)
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

bool v=true;
System.Console.Write("Введите значение n(кол-во строк): ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение k(кол-во столбцов): ");
int k=Convert.ToInt32(Console.ReadLine());
int[,] a= Random2DArray(n,k);
Print2DArray(a,v);
int[] temp= Temp(a);
Swap(ref a,temp,ref v);
Print2DArray(a,v);
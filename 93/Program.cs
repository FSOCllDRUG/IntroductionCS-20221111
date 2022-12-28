// Задача 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] Random2DArray(int n=4,int k=4,int min=0,int max=9)
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

int[,] Product(int[,] twoDArrayOne, int[,] twoDArrayTwo)
{
   int[,] a=new int [twoDArrayOne.GetLength(0),twoDArrayOne.GetLength(1)];
   for(int l=0;l<a.GetLength(1);l++)
   {
        for(int i=0;i<a.GetLength(0);i++)
        {
             a[l,i]=twoDArrayOne[l,i]*twoDArrayTwo[l,i];
        }
   }  
    return a;
}

int[,] twoDArrayOne=Random2DArray();
int[,] twoDArrayTwo=Random2DArray();
System.Console.WriteLine("1-ая матрица");
Print2DArray(twoDArrayOne);
System.Console.WriteLine("2-ая матрица");
Print2DArray(twoDArrayTwo);
int[,] TwoDProduct=Product(twoDArrayOne, twoDArrayTwo);
System.Console.WriteLine("Матрица(1*2)");
Print2DArray(TwoDProduct);
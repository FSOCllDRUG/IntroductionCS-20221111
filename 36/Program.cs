// 36.Определить, присутствует ли в заданном массиве, некоторое число

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max);
    return a;
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int LinearSearch(int[] m,int find,int startIndex=0)
{
    int i=startIndex;
    while(i<m.Length && m[i]!=find) i++;
    if (i==m.Length)
        return -1;
    else
        return i;
}


int[] m=RandomIntArray();
System.Console.Write("Введите число, для поиска в массиве: ");
int find=Convert.ToInt32(Console.ReadLine());
m[5]=find;
Print(m);
System.Console.WriteLine();
int i=LinearSearch(m,find);
if (i==-1)
    System.Console.WriteLine($"Число {find} в массиве не найдено :(");
else
    System.Console.WriteLine($"Число {find} найдено в {i} ячейке! ;)");

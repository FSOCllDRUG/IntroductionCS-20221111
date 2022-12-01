// 37.Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] RandomIntArray(int size=15,int min=100,int max=999)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}
int even=0;
int odd=0;

void Counter(int[] a,ref int even, ref int odd)
{
    foreach(int num in a)
    {
        if (num%2==0) even++;
        else odd++;
    }

}

int[] a=RandomIntArray();
Counter(a,ref even,ref odd);
System.Console.WriteLine($"В массиве было найдено {even} четных значений и {odd} нечётных значений. ");

// 38.В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int size=123,int min=0,int max=200)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int Counter(int[] a)
{
   int count=0;
    foreach(int num in a)
    {
if (num >=10 && num<=99) count++;
    }
    
    return count;
}

int[] a=RandomIntArray();
System.Console.WriteLine($"В массиве было найдено {Counter(a)} значений в диапазоне от 10 до 99");

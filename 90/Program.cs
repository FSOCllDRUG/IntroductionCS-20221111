// // // 90. Есть два массива info и data.
// // // Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
// // // Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
// // // Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
// // // Пример:
// // // входные данные:
// // // data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// // // info = {2, 3, 3, 1}

// // // выходные данные:
// // // 1, 7, 0, 1

// // // То есть, 2 бита, потом еще 3 бита, потом еще 3 бита и еще 1 бит. Переводим биты в десятичное представление.
// // // Какие ошибки могут возникнуть при обработке наборов данных?


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i]} ");
    System.Console.WriteLine();
}

int[] RandomIntArray(int size,int min=0,int max=1)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int DataSize(int[] info)
{
    int sum=0;
    for(int i=0;i<info.Length;i++) if(info[i]!=0) sum+=info[i];
    return sum;
}

void BitsToInteger(int[] d, int[] info,ref int l, ref int[] result)
{
    double sum = 0;
    for (int f = 0; f < d.Length; f++)
    {
        sum = sum + Math.Pow(2, f) * d[d.Length - f - 1];
    }
    result[l] = Convert.ToInt32(sum);
    l++;
}

void Result(int[] info, int[] data, int l, ref int[] result)
{
    int k = -1;
    for (int i = 0; i < info.Length; i++)
    {
        int[] d = new int[info[i]];
        for (int j = 0; j < info[i]; j++)
        {
            k++; 
            d[j] = data[k];
        }
        BitsToInteger(d, info, ref l, ref result);
    }
}

System.Console.WriteLine("Введите(!через пробел!) значения количества бит(!1-8!) для генерации чисел массива \"data\" ");
int[] info=Array.ConvertAll(Console.ReadLine()!.Trim().Split(' '),Convert.ToInt32);
System.Console.Write("Info: ");
Print(info);
int size =DataSize(info);
int[] data= RandomIntArray(size);
System.Console.Write("Data: ");
Print(data);
int[] result = new int[info.Length];
int l = 0;
Result(info, data, l, ref result);
System.Console.Write("Итог: ");
Print(result);


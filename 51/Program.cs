// 51.С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры.

int[] Zapoln(int n)
{
    int[] a= new int [n];
    for(int i=0;i<n;i++)
        {
            System.Console.Write($"Введите значение ячейки {i}: ");
            a[i]=Convert.ToInt32(Console.ReadLine());
        }
    return a;
}

void CounterMoreThanZero(int[] a,ref int count)
{
    foreach(int num in a)
    {
        if (num>0) count++;
    }
}

System.Console.Write("Введите кол-во элементов массива: ");
int n=Convert.ToInt32(Console.ReadLine());
int[] a=Zapoln(n);
int count=0;
CounterMoreThanZero(a,ref count);
System.Console.WriteLine($"В массив было введено {count} чисел больше 0.");
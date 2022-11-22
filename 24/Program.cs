// 24.Вывести на экран таблицу квадратов чисел от 1 до N

int square(int i)
{
int a=i*i;
return a;
}

System.Console.Write("Введите число, до которого будут вычислятся квадраты: ");
int N=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=N;i++)
{
System.Console.WriteLine($"{i}^2={square(i)}");
}

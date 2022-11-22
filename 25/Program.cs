// 25.Вывести на экран кубы чисел от 1 до N

int cube(double i)
{
int a=(int)Math.Pow(i,3);
return a;
}

System.Console.Write("Введите число, до которого будут вычислятся кубы: ");
int N=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=N;i++)
{
System.Console.WriteLine($"{i}^3={cube(i)}");
}

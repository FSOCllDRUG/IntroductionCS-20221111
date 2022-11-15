// 9.Вывести на экран четные числа от 1 до N
System.Console.Write("Введите число, для верхней границы поиска чётных чисел:");
int N=Convert.ToInt32(Console.ReadLine());
// int i=1;
// while (i<=N)
// {
//     System.Console.Write($"{i} ");
//     i=i+1;
// }
// System.Console.WriteLine();
System.Console.Write($"Чётные числа до числа {N}: ");
for (int i=2;i<=N;i=i+2)
{
    System.Console.Write($"{i} ");
}
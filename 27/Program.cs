// 27.Возведите число А в натуральную степень B используя цикл

// int Pow(int A, int B, int a)
// {
//     // int a=A;
//     // int i=2;
//     // while(i<=B)
//     // {
//     // A=A*a;
//     // i++;
//     // }
//     for (int i = 1; i < B; i++) A=A*a;
//     return A;
// }

// System.Console.Write("Введите число A: ");
// int A=Convert.ToInt32(Console.ReadLine());
// int a=A;
// System.Console.Write("Введите число B: ");
// int B=Convert.ToInt32(Console.ReadLine());
// // int i=B;
// System.Console.Write($"{a}^{B}={Pow(A,B,a)}");
// A*=B;

int Pow(int A, int B)
{
    int x=1;
    for (int i = 0; i < B; i++) x*=A;
    return x;
}
System.Console.Write("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B=Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{A}^{B}={Pow(A,B)}");

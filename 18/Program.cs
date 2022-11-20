// 18.По двум заданным числам проверять является ли одно квадратом другого.

System.Console.Write("Введите число a: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a*a==b) System.Console.WriteLine($"b={b} является квадратом a={a}");
    else
        if (b*b==a) System.Console.WriteLine($"a={a} является квадратом b={b}");
        else System.Console.WriteLine("Ни одно число не является квадратом другого");
        
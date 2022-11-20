// 17.Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

System.Console.Write("Введите число обозначающее день недели: ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(n);
if (n==6 || n==7)
{
    System.Console.WriteLine("Введённое число относится к выходным.");
}
else System.Console.WriteLine("Введённое число не относится к выходным.");
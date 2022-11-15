// 6.Написать программу вычисления значения функции y = sin(a). 
System.Console.Write("Введите градусную меру угла, синус которого будет вычисляться: ");
double a=Convert.ToDouble(Console.ReadLine());
double y=Math.Sin(a);
System.Console.WriteLine($"Синус угла {a} равен {y}");
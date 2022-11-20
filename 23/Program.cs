// 23.Найти расстояние между точками в пространстве 2D

//Ввод данных
double x1,x2,y1,y2,distance;
System.Console.Write("Введите x1: ");
x1=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите y1: ");
y1=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите x2: ");
x2=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите y2: ");
y2=Convert.ToDouble(Console.ReadLine());
//Вычисление расстояния между точками
distance=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
//Вывод
System.Console.WriteLine($"Расстояние между точками равняется {distance}");
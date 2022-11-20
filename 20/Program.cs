// 20.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

double x,y;
System.Console.Write("Введите x: ");
x=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите y: ");
y=Convert.ToDouble(Console.ReadLine());
if (x>0 && y>0) System.Console.WriteLine("Точка относится к I четверти.");
if (x<0 && y>0) System.Console.WriteLine("Точка относится к II четверти.");
if (x<0 && y<0) System.Console.WriteLine("Точка относится к III четверти.");
if (x>0 && y<0) System.Console.WriteLine("Точка относится к IV четверти.");

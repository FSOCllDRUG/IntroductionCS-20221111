// 53.Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
void Cross(float k1, float k2, float b1, float b2,out float x, out float y)
{
    x=(b2-b1)/(k1-k2);
    y=(k1*(b2-b1))/(k1-k2)+b1;
}

System.Console.WriteLine("Введите значение k1:");
float k1= float.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите значение b1:");
float b1= float.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите значение k2:");
float k2= float.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите значение b2:");
float b2= float.Parse(Console.ReadLine()!);
Cross(k1,k2,b1,b2,out float x,out float y);
System.Console.WriteLine($"Координаты точки пересечения: ({x},{y}).");
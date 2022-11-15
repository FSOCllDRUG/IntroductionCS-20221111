 // 1.С клавиатуры вводится целое число. Вывести квадрат числа. 

 int a;
 System.Console.Write("Число возводимоев в квадрат:");
 string? s=Console.ReadLine();
 a=Convert.ToInt32(s);
 int b=a*a;
 System.Console.WriteLine($"{a}^2={b}");
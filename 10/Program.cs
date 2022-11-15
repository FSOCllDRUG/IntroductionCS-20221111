// 10.Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

System.Console.Write("Введите целое число: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=a%10;
System.Console.WriteLine($"Последней цифрой введённного числа является: {b}");
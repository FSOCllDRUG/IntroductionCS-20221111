// 15.С клавиатуры вводится целое число. Вывести третью цифру(с конца) числа или сообщить, что её нет (Вывести: NO).

//3-я цифра с начала
System.Console.Write("Введите целое число:");
int a=Convert.ToInt32(Console.ReadLine());
if (a>=100)
{
System.Console.WriteLine($"Третьей цифрой(с коцна) является {a/100%10}");
}
else
{
    System.Console.WriteLine("NO");
}
//3-я цифра с конца
//System.Console.Write("Введите целое число:");
// int b=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(b/100);
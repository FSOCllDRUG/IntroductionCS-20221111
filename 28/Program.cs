// 28.Определить количество цифр в числе. Сделать подпрограмму.

//Подпрограмма
int CountDigits(int Number)
{
    Number=Math.Abs(Number);
    int count=0;
    if (Number==0) count=1;
    while (Number>0)
    {
        Number=Number/10;
        count++;
    }
    return count;
}
System.Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Цифр в числе: {CountDigits(N)}");
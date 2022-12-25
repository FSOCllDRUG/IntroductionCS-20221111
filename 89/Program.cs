// 89. Подсчитать сумму цифр, встречающихся в строке

void Check(char[] ch,ref int sum)
{
for(int i=0;i<ch.Length;i++)
{
    if (Char.IsDigit(ch[i])==true) {sum+=(int)Char.GetNumericValue(ch[i]);}
    
}
}

System.Console.Write("Ввод: ");
int sum=0;
string st=Console.ReadLine()!;
char[] ch=st.ToCharArray();
Check(ch,ref sum);
System.Console.WriteLine($"Сумма цифр в строке= {sum}");
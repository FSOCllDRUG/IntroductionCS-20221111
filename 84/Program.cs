// 84. Определить являются ли введенные с клави
// атуры символы правильно записью целого числа.
// Вычислить сумму цифр введенного числа.

void Check(char[] ch,ref int sum,ref bool test)
{
for(int i=0;i<ch.Length;i++)
{
    if (Char.IsDigit(ch[i])==true) {test=true; sum+=(int)Char.GetNumericValue(ch[i]);}
    else {test=false; break;}
    
}
}

void Output(bool test, int sum)
{
if (test==true) {System.Console.WriteLine($"Ввод верный! Сумма цифр числа= {sum}");}
else System.Console.WriteLine("Неправильный ввод!");
}

System.Console.Write("Ввод: ");
bool test=false;
int sum=0;
string st=Console.ReadLine()!;
char[] ch=st.ToCharArray();
Check(ch,ref sum,ref test);
Output(test,sum);
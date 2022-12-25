// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
void Check(char[] ch,ref int sum,char search)
{
for(int i=0;i<ch.Length;i++)
{
    if (ch[i]==search) sum++; 
}
}

int sum=0;
System.Console.Write("Нажмите на клавишу искомого символа(чувствительно к регистру): ");
char search= Console.ReadKey().KeyChar;
System.Console.WriteLine();
System.Console.WriteLine("Введите строку, в которой будет производится подсчёт использований выбранного символа: ");
string st=Console.ReadLine()!;
char[] ch=st.ToCharArray();
Check(ch,ref sum,search);
System.Console.WriteLine($"Символ {search} был использован {sum} раз.");

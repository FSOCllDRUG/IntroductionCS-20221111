// 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и конечную строку

string Replace(string[] subs, string v, string w)
{
for (int i=0;i<subs.Length;i++) if (subs[i]==w) subs[i]=v;

return string.Join(" ",subs);
}


System.Console.Write("Введите строку st: ");
string st=Console.ReadLine()!;
System.Console.Write("Введите строку w: ");
string w=Console.ReadLine()!;
System.Console.Write("Введите строку v: ");
string v=Console.ReadLine()!;
string[] subs = st.Split(' ');
string st1=Replace(subs,v,w);
System.Console.WriteLine($"Исходная строка: \"{st}\"");
System.Console.WriteLine($"Изменённая строка: \"{st1}\"");





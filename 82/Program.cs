// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
int Count(char[] ch)
{
    int count=0;
for(int i=0;ch[i]!='.';i++)
count++;
return count;
}

string st= Console.ReadLine()!;
char[] ch=st.ToCharArray();
System.Console.WriteLine(Count(ch));
void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}

void Perimetr(int m,int n,ref int value,ref int[,] array)
{
for (int y = 0; y < n; y++)
{
    array[0, y] = value;
    value++;
}
for (int x = 1; x < m; x++)
{
    array[x, n - 1] = value;
    value++;
}
for (int y = n - 2; y >= 0; y--)
{
    array[m - 1, y] = value;
    value++;
}
for (int x = m - 2; x > 0; x--)
{
    array[x, 0] = value;
    value++;
}
}

void Vnutri(int m,int n,ref int value,ref int[,] array)
{
int c = 1;
int d = 1;
while (value < m * n)
{
    while (array[c, d + 1] == 0)
    {
        array[c, d] = value;
        value++;
        d++;
    }
    while (array[c + 1, d] == 0)
    {
        array[c, d] = value;
        value++;
        c++;
    }
    while (array[c, d - 1] == 0)
    {
        array[c, d] = value;
        value++;
        d--;
    }
    while (array[c - 1, d] == 0)
    {
        array[c, d] = value;
        value++;
        c--;
    }
}
}
void Poslednyaya(int m,int n,ref int value,ref int[,] array)
{
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] == 0)
        {
            array[x, y] = value;
        }
    }
}
}

int m = 4;
int n = 4;
int value = 1;
int[,] array = new int[m, n];
Perimetr(m,n,ref value,ref array);
Vnutri(m,n,ref value,ref array);
Poslednyaya(m,n,ref value,ref array);
Print2DArray(array);

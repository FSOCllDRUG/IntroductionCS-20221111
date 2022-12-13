// 55.Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// просто перемножить
void Clear(ref string input)
{

input = input.Replace(",", " ");
input = input.Replace("(", " ");
input = input.Replace(")", " ");
input = input.Replace("  ", "");
input = input.TrimStart();
}

float[] Convert(string[] b)
{
    float[] nums = new float[b.Length-1];
    for(int i = 0; i < b.Length;i++)
{
    try
    {
        nums[i] = float.Parse(b[i]);
//    nums[i] = Convert.ToInt32(b[i].ToString());
    }
    catch (FormatException)
    {
    }
    
}
return nums;
}

float[] Scaling(float[] nums,float k)
{
    for(int i=0;i<nums.Length;i++)
    nums[i]=nums[i]*k;
    return nums;
}

void Print(float[] a)
{
    int flag=0;
    for(int i=0;i<a.Length;i++)
    {
        if(flag==0)
        {
        System.Console.Write($"({a[i]},");
        flag++;
        }
        else
        {
            System.Console.Write($"{a[i]}) ");
        flag--;
        }
    }
}

System.Console.WriteLine("Введите вершины фигуры списком (одной строкой)\nнапример: (0,0) (2,0) (2,2) (0,2)");
string input= Console.ReadLine()!;
Clear(ref input);
string[] b = input.Split(' ');
float[] nums= Convert(b);
System.Console.Write("Введите коэффицент масштабирования k: ");
float k= float.Parse(Console.ReadLine()!);
Scaling(nums,k);
Print(nums);


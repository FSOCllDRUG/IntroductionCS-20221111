// 22.Программа проверяет пятизначное число на палиндромом.

System.Console.Write("Введите пятизначное число: ");
int n=Convert.ToInt32(Console.ReadLine());
int num=n;
int[] nums= new int[5];
int i=0;
while (i<=4)
{
nums[i]=n%10;
n=n/10;
i++;
}
if (nums[0]==nums[4] && nums[1]==nums[3])System.Console.WriteLine($"Число {num} является палиндромом.");
else System.Console.WriteLine($"Число {num} не является палиндромом");
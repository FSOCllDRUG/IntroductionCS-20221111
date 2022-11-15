// 4.По заданному с клавиатуры номеру дня недели вывести его название

System.Console.Write("Введите номер дня недели(1-7): ");
int a=Convert.ToInt32(Console.ReadLine());
string[] DaysOfWeek= {"", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
System.Console.WriteLine($"Вы выбрали \"{DaysOfWeek[a]}\" ");

using System;
namespace Task01
{
 class Program
 {
 static void Main(string[] args)
 {
 Console.SetWindowSize(160, 30);
 Console.Title = "Struna Viktor 525b";
 Console.BackgroundColor = ConsoleColor.DarkCyan;
 Console.ForegroundColor = ConsoleColor.Green;
 Console.WriteLine("Input your name:");
 string s = Console.ReadLine();
 Console.ForegroundColor = ConsoleColor.Red;
 DateTime NewYear = new DateTime(DateTime.Now.Year, 12, 31);
 DateTime now = DateTime.Now;
 TimeSpan ts = NewYear - now;
 int days = (int)ts.TotalDays;
 Console.WriteLine("Hello, {0}!", s);
 DateTime dt = DateTime.Now;
 Console.WriteLine("Today is {0}, {1}.{2}.{3}", dt.DayOfWeek, dt.Day, dt.Month,
dt.Year);
 Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
 Console.WriteLine("Still to NewYear " + days + " days");
 Console.Beep();
 }
 }
}

using System;
using System.Xml.Schema;
using Practice;
namespace Practise
{
 class Figure
 {
 public static void Input_Info(Geometric_Shapes i)
 {
 Console.WriteLine("Введите название фигуры: ");
 i.Name = Console.ReadLine();
 try
 {
 Console.WriteLine("Введите периметр фигуры: ");
 i.Perimeter = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите площадь фигуры: ");
 i.Area = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите количество углов: ");
 i.Corners = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите количество фигур: ");
 i.Number = int.Parse(Console.ReadLine());
 }
 catch (System.FormatException)
 {
 Console.WriteLine("Неправильный ввод!");
 }
 }
 static void Main(string[] args)
 {
 Geometric_Shapes[] arr = new Geometric_Shapes[2];
 Circle circle = new Circle();
 Square square = new Square();
 Console.WriteLine("Введите информацию про круг:");
 Input_Info(circle);
 Console.WriteLine("Введите информацию про квадрат:");
 Input_Info(square);
 arr[0] = circle; arr[1] = square;
 for (; ; )
 {
 string[] action;
 int i;
 scan:
 Console.WriteLine("Введите 1,чтобы выбрать круг, 2 чтобы выбрать квадрат: ");
 int.TryParse(Console.ReadLine(), out i);
 if (i < 1 || i > 2)
 {
 Console.WriteLine("Неправильный ввод!");
 goto scan;
 }
 else
 i--;
 Console.WriteLine("Действия: ");
 Console.WriteLine("sn 'name' ввести имя\t\t\t\tgn получить имя");
 Console.WriteLine("sp 'perimeter' ввести периметр\t\t\tgp получить периметр");
 Console.WriteLine("sa 'area' ввести площадь\t\t\tga получить площадь");
 Console.WriteLine("sc 'corners' ввести количество углов\t\tgc получить
количество углов");
 Console.WriteLine("su 'number' ввести количество фигур\t\tgu получить
количество фигур");
 Console.WriteLine("pa вывести всю информацию\t\t\tex выход");
 Console.WriteLine("Введите: ");
 action = Console.ReadLine().Split(" ");
 if (action[0] == "sn") arr[0].Name = action[1];
 try
 {
 if (action[0] == "sp")
 arr[0].Perimeter = int.Parse(action[1]);
 if (action[0] == "sa")
 arr[0].Area = int.Parse(action[1]);
 if (action[0] == "sc")
 arr[0].Corners = int.Parse(action[1]);
 if (action[0] == "su")
 arr[0].Number = int.Parse(action[1]);
 }
 catch (System.FormatException)
 {
 Console.WriteLine("Неправильный ввод!");
 }
 if (action[0] == "gn")
 Console.WriteLine($"Название: {arr[i].Name}");
 if (action[0] == "gp")
 Console.WriteLine($"Периметр: {arr[i].Perimeter}");
 if (action[0] == "ga")
 Console.WriteLine($"Площадь: {arr[i].Area}");
 if (action[0] == "gc")
 Console.WriteLine($"Количество углов: {arr[i].Corners}");
 if (action[0] == "gu")
 Console.WriteLine($"Количество фигур: {arr[i].Number}");
 if (action[0] == "pa")
 Console.WriteLine(arr[i].GetInfo());
 if (action[0] == "ex")
 break;
 }
 }
 }
}

Текст программы
using System;
using System.IO;
using System.Text.RegularExpressions;
namespace Lab7_1
{
 public class Program
 {
 void PrintHelp()
 {
 Console.WriteLine("Это приложение проверяет, является ли строка действительным hex индентификатором цвета в HTML.");
 Console.WriteLine("Аргумент командной строки: / h - справка, / f 'имя_файла' - проверка из файла, / s - чтение строк из CLI");
 }
 public bool CheckString(string str)
 {
 Regex hex = new Regex("^(#[aA-fF0-9]{6}$)");
 return hex.IsMatch(str);
 }
 static void Main(string[] args)
 {
 Program program = new Program();
 if (args.Length > 0)
 {
 if (args[0] == "/?" || args[0] == "/h")
 program.PrintHelp();
 if (args[0] == "/s")
 {
 if (args.Length > 1)
{
 for (int i = 1; i < args.Length; i++)
 {
 if (program.CheckString(args[i]))
 Console.WriteLine($"{args[i]} это действующий hex");
 else
 Console.WriteLine($"{args[i]} не действительный hex");
 }
 }
if (args[0] == "/f")
{
 using (StreamReader sr = new StreamReader(args[1]))
{
 string[] file_input = sr.ReadToEnd().Split();
 foreach (string str in file_input)
{
 if (program.CheckString(str))
 Console.WriteLine($"{str} это действующий hex");
 else
 Console.WriteLine($"{str} не действительный hex");
 }
 }
 }
 }
 }
 else
 {
 Console.WriteLine("Вы можете ввести 'end', чтобы остановить программу.");
 for (; ; )
 {
 Console.WriteLine("Введите строку: ");
 string input = Console.ReadLine();
 if (input == "end")
 break;
 string[] array = input.Split();
foreach (string str in array)
{
 if (program.CheckString(str))
 Console.WriteLine($"{str} это действующий hex");
 else
 Console.WriteLine($"{str} не действительный hex");
 }
 }
 }
 }
 }
}

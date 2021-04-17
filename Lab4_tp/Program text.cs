using System;
using System.Collections.Generic;
using Lab4_tp_bibl_;
namespace Lab04
{
 class Program
 {
 static void Input_Info(RadiusVector i)
 {
 Console.WriteLine("Введите координаты вектора:");
 Console.Write("x: ");
 i.X1 = int.Parse(Console.ReadLine());
 Console.Write("y: ");
 i.Y1 = int.Parse(Console.ReadLine());
 }
 static void Main(string[] args)
 {
 RadiusVector vector = new RadiusVector();
 Input_Info(vector);
 RadiusVector vector1 = new RadiusVector();
 Input_Info(vector1);
 for (; ; )
 {
 string[] action;
 menu:
 Console.WriteLine("\nДействия: ");
 Console.WriteLine("'i' Вывести информацию про вектор.\n");
 Console.WriteLine("'a' Выполнить сложения векторов.\n");
 Console.WriteLine("'s' Выполнить вычитание векторов.\n");
 Console.WriteLine("'m' Выполнить умножение вектора на число.\n");
 Console.WriteLine("'d' Выполнить деление вектора на число.\n");
 Console.WriteLine("'c' Выполнить сравнение векторов.\n");
 Console.WriteLine("'ex' Чтобы выйти\n");
 Console.WriteLine("Введите: ");
 action = Console.ReadLine().Split();
 if (action[0] == "i")
 {
 Console.WriteLine(vector.GetInfo());
 Console.WriteLine(vector1.GetInfo());
 }
 if (action[0] == "a")
 {
 double r = (double)vector + (double)vector1;
 Console.WriteLine($"Результат: {Math.Round(r, 3)}");
 }
 if (action[0] == "s")
 {
 double r = (double)vector + (double)vector1;
 Console.WriteLine($"Результат: {Math.Round(r, 3)}");
 }
 if (action[0] == "m")
 {
 Console.WriteLine("Выберите вектор:\n");
 Console.WriteLine($"'1' {vector.GetInfo()} \n");
 Console.WriteLine($"'2' {vector1.GetInfo()} \n");
 Console.WriteLine("Введите: ");
 string v = Console.ReadLine();
 if (v == "1")
 {
 Console.WriteLine("Введите число:");
 double b = Convert.ToDouble(Console.ReadLine());
 double r = (double)vector * b;
 Console.WriteLine($"Результат: {Math.Round(r, 3)}");
 }
 if (v == "2")
 {
 Console.WriteLine("Введите число:");
 double c = Convert.ToDouble(Console.ReadLine());
 double ra = (double)vector1 * c;
 Console.WriteLine($"Результат: {Math.Round(ra, 3)}");
 }
 }
 if (action[0] == "d")
 {
 Console.WriteLine("Выберите вектор:\n");
 Console.WriteLine($"'1' {vector.GetInfo()} \n");
 Console.WriteLine($"'2' {vector1.GetInfo()} \n");
 Console.WriteLine("Введите: ");
 string va = Console.ReadLine();
 if (va == "1")
 {
 Console.WriteLine("Введите число:");
 double b = Convert.ToDouble(Console.ReadLine());
 double r = (double)vector / b;
 Console.WriteLine($"Результат: {Math.Round(r, 3)}");
 }
 if (va == "2")
 {
 Console.WriteLine("Введите число:");
 double c = Convert.ToDouble(Console.ReadLine());
 double ra = (double)vector1 / c;
 Console.WriteLine($"Результат: {Math.Round(ra, 3)}");
 }
 }
 if (action[0] == "c")
 {
 for (; ; )
 {
 Console.WriteLine("\nКакое сравнение вы хотите сделать или введите 'b',чтобы вернуться обратно:");
 Console.WriteLine("Введите: ");
 string op = Console.ReadLine();
 if (op == "<")
 {
 Console.WriteLine(vector < vector1);
 Console.WriteLine();
 }
 if (op == ">")
 {
 Console.WriteLine(vector > vector1);
 Console.WriteLine();
 }
 if (op == "==")
 {
 Console.WriteLine(vector == vector1);
 Console.WriteLine();
 }
 if (op == "!=")
 {
 Console.WriteLine(vector != vector1);
 Console.WriteLine();
 }
 if (op == "<=")
 {
 Console.WriteLine(vector <= vector1);
 Console.WriteLine();
 }
 if (op == ">=")
 {
 Console.WriteLine(vector >= vector1);
 Console.WriteLine();
 }
 if (op == "b")
 {
 goto menu;
 }
 }
 }
 if (action[0] == "ex")
 {
 break;
 }
 }
 }
 }
 }

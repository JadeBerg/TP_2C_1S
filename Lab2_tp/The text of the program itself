/*****************************************************/
/* Лабораторная работа № 2 */
/* Абстрактные сущности и связи между ними */
/* Задание 2 */
/* Вариант 15 */
/* Выполнил студент гр. 525б Струна В.Р. */
/****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multicooker1;
namespace Lab02
{
 class Program
 {
 static void AddObject(List<Multicooker> list)
 {
 Console.WriteLine("Нажмите Enter, чтобы создать пустую мультиварку.");
 Console.WriteLine("Вы можете ничего не вводить,ввести только брэнд, ввести брэнд и
модель либо сразу все три параметра!");
 Console.WriteLine("Введите 1 для режима «Зерновые», 2 для «Тушение», 3 для
«Жарка», 4 для «Пар».");
 Console.Write("Введите брэнд, модель, режим: ");
 string input = Console.ReadLine();
 if (input == "")
 list.Add(new Multicooker());
 else
 {
 string[] inputs = input.Split(' ');
 if (inputs.Length == 1)
 list.Add(new Multicooker(inputs[0]));
 if (inputs.Length == 2)
 {
 list.Add(new Multicooker(inputs[0], inputs[1]));
 }
 if (inputs.Length == 3)
 {
 Modes mode = Modes.Cereals;
 if (inputs[2] == "2")
 mode = Modes.Extinguishing;
 if (inputs[2] == "3")
 mode = Modes.Frying;
 if (inputs[2] == "4")
 mode = Modes.Steam;
 list.Add(new Multicooker(inputs[0], inputs[1], mode));
 }
 }
 }
 static void ActionMenu(List<Multicooker> list, int i)
 {
 string input;
 int temp;
 Console.WriteLine("Введите 1, чтобы включить режим «Зерновые».");
 Console.WriteLine("Введите 2, чтобы включить режим «Тушение».");
 Console.WriteLine("Введите 3, чтобы включить режим «Жарка».");
 Console.WriteLine("Введите 4, чтобы включить режим «Пар».");
 Console.WriteLine("Введите 5, чтобы включить мультиварку.");
 Console.WriteLine("Введите 6, чтобы выключить мультиварку.");
 Console.WriteLine("Введите 7, чтобы увидеть информацию об мультиварке.");
 for (; ; )
 {
 input = Console.ReadLine();
 int.TryParse(input, out temp);
 if (temp > 0 && temp < 8)
 break;
 }
 if (temp == 1)
 list[i].SetMode(1);
 if (temp == 2)
 list[i].SetMode(2);
 if (temp == 3)
 list[i].SetMode(3);
 if (temp == 4)
 list[i].SetMode(4);
 if (temp == 5)
 list[i].TurnOn();
 if (temp == 6)
 list[i].TurnOff();
 if (temp == 7)
 Console.WriteLine(list[i].GetState());
 }
 static void Main(string[] args)
 {
 List<Multicooker> objects = new List<Multicooker>();
 string input;
 bool exit = false;
 for (; ; )
 {
 int i = 0;
 if (objects.Count == 0)
 {
 Console.WriteLine("Введите c, чтобы создать мультиварку");
input = Console.ReadLine();
for (; ; )
 {
 if (input == "c")
 {
 AddObject(objects); break;
 }
 }
 }
 else
 {
 Console.WriteLine($"Есть {objects.Count} мультиварки(ок). Выбирете одну из
них или введите 'с', чтобы создать новую.");
 for (; ; )
 {
 Console.WriteLine("Введите 'e', чтобы выйти.");
 input = Console.ReadLine();
if (input == "c")
 {
 AddObject(objects); break;
 }
if (input == "e")
 {
 exit = true; break;
 }
int.TryParse(input, out i);
 if (i > 0 && i <= objects.Count)
 {
 i--;
break;
 }
 }
ActionMenu(objects, i);
 }
 if (exit)
 break;
 }
 }
 }
}

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System;
using System.IO;
using System.Collections.Generic;
namespace Lab6_2
{
 public class Rootobject
 {
 public List<PeopleInfo> Property1 { get; set; }
 }
 public class PeopleInfo
 {
 public string surname { get; set; }
 public string name { get; set; }
 public string gender { get; set; }
 public int age { get; set; }
 public string location { get; set; }
 public PeopleInfo()
 {
 }
 public PeopleInfo(string name, string surname, string gender, int age, string location)
 {
 this.name = name;
 this.surname = surname;
 this.gender = gender;
 this.age = age;
 this.location = location;
 }
 }
 public class Func
 {
 public void PrintMenu()
 {
 Console.WriteLine();
 Console.WriteLine("Команды: ");
 Console.WriteLine("0) Выйти\n1) Добавить запись");
 Console.WriteLine("2) Удалить запись\n3) Вывести все записи");
 Console.WriteLine("4) Изменить запись\n5) Найти запись");
 Console.WriteLine("6)Сохранить запись в файл");
 Console.WriteLine("Введите команду: ");
 }
 public int HandleInput(string input, List<PeopleInfo> list,
DataContractJsonSerializer serializer)
 {
 int exit = 0;
 if (input.ToLower() == "0")
 {
 Stream fs = new FileStream("PeopleInfo.json", FileMode.Create);
 serializer.WriteObject(fs, list);
 Console.WriteLine("Файл сохранен!");
 exit = 1;
 }
 if (input.ToLower() == "1")
 {
 Console.WriteLine("Введите имя: ");
 string name = Console.ReadLine();
 Console.WriteLine("Введите фамилию: ");
 string surname = Console.ReadLine();
 Console.WriteLine("Введите пол: ");
 string gender = Console.ReadLine();
 Console.WriteLine("Введите место жительства: ");
 string location = Console.ReadLine();
 Console.WriteLine("Введите возраст: ");
 int age = Convert.ToInt32(Console.ReadLine());
 PeopleInfo newDep = new PeopleInfo(name,surname, gender, age, location);
 list.Add(newDep);
 }
 if (input.ToLower() == "2")
 {
 int index = 0;
 Console.WriteLine("Введите индекс записи [max = {0}]: ", list.Count);
 index = int.Parse(Console.ReadLine());
 list.RemoveAt(index);
 }
 if (input.ToLower() == "3")
 {
 int index = 0;
 foreach (PeopleInfo p in list)
 {
 Console.WriteLine("[{0}]\nИмя : {1}\nФамилия: {2}\nПол: {3}\nМесто жительства: {4}\nВозраст: {5}", index, p.name, p.surname, p.gender, p.location, p.age);
 index++;
 }
 Console.WriteLine();
 }
 if (input.ToLower() == "4")
 {
 int index;
 for (; ; )
 {
 Console.WriteLine("Введите индекс записи[max ={0}]: ", list.Count);
 if (int.TryParse(Console.ReadLine(), out index) && index <=
list.Count)
 break;
 }
 Console.WriteLine("Введите имя: ");
 list[index].name = Console.ReadLine();
 Console.WriteLine("Введите фамилию: ");
 list[index].surname = Console.ReadLine();
 Console.WriteLine("Введите пол: ");
 list[index].gender = Console.ReadLine();
 Console.WriteLine("Введите возраст: ");
 list[index].age = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите место жительства: ");
 list[index].location = Console.ReadLine();
 }
 if (input.ToLower() == "5")
 {
 string ask = "";
 Console.WriteLine("Введите\n'1' искать по имени\n'2' искать по возрасту:");
 ask = Console.ReadLine();
 if (ask == "1")
 {
 string name;
 Console.WriteLine("Введите имя для поиска:");
 name = Console.ReadLine();
 int index = 0;
foreach (PeopleInfo elem in list)
 {
 if (elem.name == name)
{
 Console.WriteLine($"Запись найдена по индексу {index}");
 break;
 }
index++;
 }
if (index == list.Count && list[index - 1].name != name)
 Console.WriteLine("Запись не найдена!!");
 }
 if (ask == "2")
 {
 Console.WriteLine("Введите возраст: ");
 int AgeCheck = Convert.ToInt32(Console.ReadLine());
int index = 0;
 foreach (PeopleInfo elem in list)
 {
 if (elem.age ==AgeCheck)
{
 Console.WriteLine($"Запись найдена по индексу {index}");
 break;
 }
index++;
 }
if (index == list.Count && list[index - 1].age !=AgeCheck)
 Console.WriteLine("Запись не найдена!!");
 }
 }
 if (input.ToLower() == "6")
 {
 Console.WriteLine("Введите путь для сохранения или введите 'i' для сохранения в папке по умолчанию:");
 string path = Console.ReadLine();
 if (path == "i")
 {
 int index = 0;
string res = "";
 foreach (PeopleInfo elem in list)
 {
 res += $"Номер записи:{index}\nИмя:{elem.name}\nФамилия:{elem.surname}\nПол:{elem.gender}\nВозраст:{elem.age}\nМесто жительства:{elem.location}";
 res += "\n";
 index++;
 }
res = res.Trim();
File.WriteAllText("text.txt", res);
 Console.WriteLine("Файл сохранен!");
 }
 else
 {
 try
{
 string res = "";
 FileInfo test = new FileInfo(path);
 int index = 0;
foreach (PeopleInfo elem in list)
 {
 res += $"Номер записи:{index}\nИмя:{elem.name}\nФамилия:{elem.surname}\nПол:{elem.gender}\nВозраст:{elem.age}\nМесто жительства:{elem.location}";
 res += "\n";
 index++;
 }
res = res.Trim();
if (!path.Contains(".txt"))
 path += "/text.txt";
 File.WriteAllText(path, res);
Console.WriteLine("Файл сохранен!");
 }
catch
{
 Console.WriteLine("Невозможно получить доступ к папке");
 }
 }
 }
 return exit;
 }
 }
}

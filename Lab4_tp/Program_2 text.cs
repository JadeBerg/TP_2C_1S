using System;
namespace Practise
{
 interface IVolume
 {
 void Volume(int added_Volume);
 void Volume1(int sub_Volume);
 int VolumeInfo();
 }
 interface IBrightness
 {
 void Brightness(int added_Brightness);
 void Brightness1(int sub_Brightness);
 int BrightnessInfo();
 }
 // Родительский класс
 public abstract class Appliances
 {
 public bool Appliances_On
 { get; private set; }
 public string Name
 { get; }
 public Appliances(string name)
 {
 Name = name;
 Appliances_On = false;
 }
 public void TurnOn()
 {
 Appliances_On = true;
 }
 public void TurnOff()
 {
 Appliances_On = false;
 }
 public virtual void Use()
 {
 if (Appliances_On)
 Console.WriteLine();
 }
 }
 public class Lamp : Appliances, IBrightness
 {
 private int b;
 public Lamp(string name) : base(name)
 {
 b = 100;
 }
 public override void Use()
 {
 if (Appliances_On)
 {
 base.Use();
 Console.WriteLine("Лампа включена.");
 Console.WriteLine($"Яркость лампы сейчас {b}.");
 }
 else
 Console.WriteLine("Лампа выключена.");
 }
 public void Brightness(int added_Brightness)
 {
 if (b + added_Brightness > 100)
 {
 Console.WriteLine("Слишком много добавьте меньше!");
 }
 else
 {
 b += added_Brightness;
 }
 }
 public void Brightness1(int sub_Brightness)
 {
 if (b - sub_Brightness < 0)
 {
 Console.WriteLine("Слишком много убавьте меньше!");
 }
 else
 {
 b -= sub_Brightness;
 }
 }
 public int BrightnessInfo()
 {
 return b;
 }
 }
 public class TV : Appliances, IBrightness, IVolume
 {
 private int b;
 private int v;
 public TV(string name) : base(name)
 {
 b = 100;
 v = 100;
 }
 public override void Use()
 {
 if (Appliances_On)
 {
 base.Use();
 Console.WriteLine("Телевизор включен.");
 Console.WriteLine($"Яркость телевизора сейчас {b} и громкость {v}.");
 }
 else
 Console.WriteLine("Телевизор выключен.");
 }
 public void Brightness(int added_Brightness)
 {
 if (b + added_Brightness > 100)
 {
 Console.WriteLine("Слишком много добавьте меньше!");
 }
 else
 {
 b += added_Brightness;
 }
 }
 public void Brightness1(int sub_Brightness)
 {
 if (b - sub_Brightness < 0)
 {
 Console.WriteLine("Слишком много убавьте меньше!");
 }
 else
 {
 b -= sub_Brightness;
 }
 }
 public int BrightnessInfo()
 {
 return b;
 }
 public void Volume(int added_Volume)
 {
 if (v + added_Volume > 100)
 {
 Console.WriteLine("Слишком много добавьте меньше!");
 }
 else
 {
 v += added_Volume;
 }
 }
 public void Volume1(int sub_Volume)
 {
 if (v - sub_Volume < 0)
 {
 Console.WriteLine("Слишком много убавьте меньше!");
 }
 else
 {
 v -= sub_Volume;
 }
 }
 public int VolumeInfo()
 {
 return v;
 }
 }
 public class Radio : Appliances, IVolume
 {
 private int b;
 private int v;
 public Radio(string name) : base(name)
 {
 v = 100;
 }
 public override void Use()
 {
 if (Appliances_On)
 {
 base.Use();
 Console.WriteLine("Радио включено.");
 Console.WriteLine($"Громкость радио сейчас {v}.");
 }
 else
 Console.WriteLine("Радио выключено.");
 }
 public void Volume(int added_Volume)
 {
 if (v + added_Volume > 100)
 {
 Console.WriteLine("Слишком много добавьте меньше!");
 }
 else
 {
 v += added_Volume;
 }
 }
 public void Volume1(int sub_Volume)
 {
 if (v - sub_Volume < 0)
 {
 Console.WriteLine("Слишком много убавьте меньше!");
 }
 else
 {
 v -= sub_Volume;
 }
 }
 public int VolumeInfo()
 {
 return v;
 }
 }
 class Program
 {
 static void CreateDevice(Appliances[] arr, int index)
 {
 Console.WriteLine("Введите названя бытового прибора: ");
 string temp = Console.ReadLine();
 if (index == 0)
 arr[index] = new Lamp(temp);
 if (index == 1)
 arr[index] = new TV(temp);
 if (index == 2)
 arr[index] = new Radio(temp);
 }
 static void Main(string[] args)
 {
 Appliances[] arr = new Appliances[3];
 int index = -1;
 bool exit = false;
 for (; ; )
 {
 for (; ; )
 {
 Console.WriteLine("Выберите устройство: \n«1»- Лампа \n«2» - Телевизор \n«3» - Радио");
 Console.WriteLine("Или введите «e» для выхода.");
 Console.WriteLine("Ввод: ");
 string temp = Console.ReadLine();
 if (temp == "1")
 {
 index = 0;
 break;
 }
 if (temp == "2")
 {
 index = 1;
 break;
 }
 if (temp == "3")
 {
 index = 2;
 break;
 }
 if (temp == "e")
 {
 exit = true;
 break;
 }
 }
 if (exit)
 break;
 for (; ; )
 {
 string temp;
 if (arr[index] == null)
 {
 CreateDevice(arr, index);
 continue;
 }
 else
 {
 Console.WriteLine("\nДействия: ");
 Console.WriteLine("«1» - Включить\n«2» - Выключить\n«3» - Использовать\n");
 if (index == 0)
 Console.WriteLine("«4» - Управление яркостью\n«5» -Информация о яркости\n");
 if (index == 1)
 {
 Console.WriteLine("«4» - Управление яркостью\n«5» -Информация о яркости\n");
 Console.WriteLine("«6» -Управление громкостью\n«7» - Информация о громкости\n");
 }
 if (index == 2)
 Console.WriteLine("«4» - -Управление громкостью\n«5» - Информация о громкости\n");
 Console.WriteLine("Введите «b» для доступа к предыдущему меню");
 Console.WriteLine("Ввод: ");
 temp = Console.ReadLine();
 }
 if (temp == "b")
 break;
 else
 {
 if (temp == "1")
 {
 arr[index].TurnOn();
 continue;
 }
 if (temp == "2")
 {
 arr[index].TurnOff();
 continue;
 }
 if (temp == "3")
 {
 arr[index].Use();
 continue;
 }
 if (temp == "4" && index == 0)
 {
 Console.WriteLine("Вы можете добавить либо убавить яркость:");
 string op;
 Console.WriteLine("1) Добавить");
 Console.WriteLine("2) Убавить");
 Console.WriteLine("Введите:");
 op = Console.ReadLine();
 if (op == "1")
 {
 Console.WriteLine("Введите сколько хотите добавить:");
 int a = Convert.ToInt32(Console.ReadLine());
 ((Lamp)arr[index]).Brightness(a);
 }
 if (op == "2")
 {
 Console.WriteLine("Введите сколько хотите убавить:");
 int a = Convert.ToInt32(Console.ReadLine());
 ((Lamp)arr[index]).Brightness1(a);
 }
 continue;
 }
 if (temp == "4" && index == 1)
 {
 Console.WriteLine("Вы можете добавить либо убавить яркость:");
 string op;
 Console.WriteLine("1) Добавить");
 Console.WriteLine("2) Убавить");
 Console.WriteLine("Введите:");
 op = Console.ReadLine();
 if (op == "1")
 {
 Console.WriteLine("Введите сколько хотите добавить:");
 int a =
Convert.ToInt32(Console.ReadLine());
 ((TV)arr[index]).Brightness(a);
 }
 if (op == "2")
 {
 Console.WriteLine("Введите сколько хотите убавить:");
 int a = Convert.ToInt32(Console.ReadLine());
 ((TV)arr[index]).Brightness1(a);
 }
 continue;
 }
 if (temp == "4" && index == 2)
 {
 Console.WriteLine("Вы можете добавить либо убавить громкость:");
 string op;
 Console.WriteLine("1) Добавить");
 Console.WriteLine("2) Убавить");
 Console.WriteLine("Введите:");
 op = Console.ReadLine();
 if (op == "1")
 {
 Console.WriteLine("Введите сколько хотите добавить:");
 int a =
Convert.ToInt32(Console.ReadLine());
 ((Radio)arr[index]).Volume(a);
 }
 if (op == "2")
 {
 Console.WriteLine("Введите сколько хотите убавить:");
 int a =
Convert.ToInt32(Console.ReadLine());
 ((Radio)arr[index]).Volume1(a);
 }
 continue;
 }
 if (temp == "5" && index == 0)
 {

Console.WriteLine($"Яркость:{((Lamp)arr[index]).BrightnessInfo()}%\n");
 continue;
 }
 if (temp == "5" && index == 1)
 {

Console.WriteLine($"Яркость:{((TV)arr[index]).BrightnessInfo()}%\n");
 continue;
 }
 if (temp == "5" && index == 2)
 {

Console.WriteLine($"Громкость:{((Radio)arr[index]).VolumeInfo()}%\n");
 continue;
 }
 if (temp == "6" && index == 1)
 {
 Console.WriteLine("Вы можете добавить либо убавить громкость:");
 string op;
 Console.WriteLine("1) Добавить");
 Console.WriteLine("2) Убавить");
 Console.WriteLine("Введите:");
 op = Console.ReadLine();
 if (op == "1")
 {
 Console.WriteLine("Введите сколько хотите добавить:");
 int a =
Convert.ToInt32(Console.ReadLine());
 ((TV)arr[index]).Volume(a);
 }
 if (op == "2")
 {
 Console.WriteLine("Введите сколько хотите убавить:");
 int a =
Convert.ToInt32(Console.ReadLine());
 ((TV)arr[index]).Volume1(a);
 }
 continue;
 }
 if (temp == "7" && index == 1)
 {

Console.WriteLine($"Громкость:{((TV)arr[index]).VolumeInfo()}%\n");
 continue;
 }
 }
 Console.WriteLine("Неправильный ввод!");
 }
 }
 }
 }
}

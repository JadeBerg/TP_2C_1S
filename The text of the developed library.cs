using System;
namespace Practiсe
{
 // Родительский класс
 public abstract class Trade_Establishment
 {
 // Хранит имя заведения
 private string name;
 // Хранит адресс заведения
 private string address;
 //Хранит телефон заведения
 private string phone;
 //Хранит количесвто персонала
 private int service;
 //Хранит количество заведений в городе
 private int number;
 //свойства имени
 public string Name
 {
 get { return name; }
 set
 {
 if (value == "")
 throw new ArgumentNullException();
 else
 name = value;
 }
 }
 //свойства адресса
 public string Address
 {
 get { return address; }
 set
 {
 if (value == "")
 throw new ArgumentOutOfRangeException();
 else
 address = value;
 }
 }
 //свойства телефона
 public string Phone
 {
 get { return phone; }
 set
 {
 if (value == "")
 throw new ArgumentOutOfRangeException();
 else
 phone = value;
 }
 }
 //свойства персонала
 public int Service
 {
 get { return service; }
 set
 {
 if (value < 0)
 throw new ArgumentOutOfRangeException();
 else
 service = value;
 }
 }
 //свойства количества заведений в городе
 public int Number
 {
 get { return number; }
 set
 {
 if (value < 0)
 throw new ArgumentOutOfRangeException();
 else
 number = value;
 }
 }
 //возвращает строку с информацией об объектах
 public virtual string GetInfo()
 {
 return $"{name} находится по адрессу {address}, номер телефона заведения -
{phone}, количество персонала = {service} таких по городу {number}.";
 }
 //Конструктор по умолчанию
 public Trade_Establishment()
 {
 }
 //Конструктор, задающий имя
 public Trade_Establishment(string Name)
 {
 this.Name = Name;
 }
 //Конструктор, задающий адресс и телефон
 public Trade_Establishment(string Address, string Phone)
 {
 this.Address = Address;
 this.Phone = Phone;
 }
 //Конструктор, задающий количество персонала и количество заведений по городу
 public Trade_Establishment(int Service, int Number)
 {
 this.Service = Service;
 this.Number = Number;
 }
 }
 //Дочерний класс
 public class Supermarket : Trade_Establishment
 {
 //Функция для получения информации
 public override string GetInfo()
 {
 return base.GetInfo();
 }
 //Конструктор по умолчанию
 public Supermarket() : base()
 {
 }
 //Конструктор, задающий имя
 public Supermarket(string Name) : base(Name)
 {
 }
 //Конструктор, задающий адресс и телефон
 public Supermarket(string Address, string Phone) : base(Address, Phone)
 {
 }
 //Конструктор, задающий количество персонала и количество заведений по городу
 public Supermarket(int Service, int Number) : base(Service, Number)
 {
 }
 }
 //Дочерний класс
 public class Stall : Trade_Establishment
 {
 //Функция для получения информации
 public override string GetInfo()
 {
 return base.GetInfo();
 }
 //Конструктор по умолчанию
 public Stall() : base()
 {
 }
 //Конструктор, задающий имя
 public Stall(string Name) : base(Name)
 {
 }
 //Конструктор, задающий адресс и телефон
 public Stall(string Address, string Phone) : base(Address, Phone)
 {
 }
 ////Конструктор, задающий количество персонала и количество заведений по городу
 public Stall(int Service, int Number) : base(Service, Number)
 {
 }
 }
}

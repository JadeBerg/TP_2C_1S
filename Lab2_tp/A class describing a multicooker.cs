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
namespace Multicooker1
{
 //Класс описания мультиварки
 public class Multicooker
 {
 //Текущий режим
 private Modes CurrentMode = Modes.Cereals;
 //Вкл./Выкл.
 private int CurrentState = 0;
 private readonly string Brand;
 private readonly string Model;
 //Все требуемые виды конструкторов
 //Если пользователь не ввел брэнд с моделью
 public Multicooker()
 {
 Brand = "Noname";
 Model = "Unknown";
 }
 //Если пользователь ввел брэнд,но не ввел модель
 public Multicooker(string brand)
 {
 Brand = brand;
 Model = "Unknown";
 }
 //Если пользователь ввел брэнд и модель
 public Multicooker(string brand, string model)
 {
 Brand = brand;
 Model = model;
 }
 //Если пользователь ввел брэнд, модель, начальный режим
 public Multicooker(string brand, string model, Modes mode)
 {
 Brand = brand;
 Model = model;
 CurrentMode = mode;
 }
 //Задание режима работы
 public void SetMode(int mode)
 {
 if (mode == 1)
 CurrentMode = Modes.Cereals;
 if (mode == 2)
 CurrentMode = Modes.Extinguishing;
 if (mode == 3)
 CurrentMode = Modes.Frying;
 if (mode == 4)
 CurrentMode = Modes.Steam;
 }
 //Включение
 public void TurnOn()
 {
 CurrentState = 1;
 }
 //Выключение
 public void TurnOff()
 {
 CurrentState = 0;
 }
 //Получение информации о состоянии
 public string GetState()
 {
 string state = $"{Brand} {Model} ";
 if (CurrentState == 0)
 state += "Выключена.";
 else
 {
 state += "Включена. Текущий режим : ";
 if (CurrentMode == Modes.Cereals)
 state += "«Зерновые»";
 if (CurrentMode == Modes.Extinguishing)
 state += "«Тушение»";
 if (CurrentMode == Modes.Frying)
 state += "«Жарка»";
 if (CurrentMode == Modes.Steam)
 state += "«Пар»";
 }
 return state;
 }
 }
}

using System;
using System.Collections.Generic;
using System.Text;
namespace Struna.Lab01.Task02.ClassLib
{
public class Furniture
{
private int ID;
private string name;
private string kind;
private string material;
private string status;
public void Print()
{
Console.WriteLine(" ID: {0}\n Name: {1}\n Kind: {2}\n Matetial: {3}\n
Status: {4} \n", ID, name, kind, material, status);
}
public int getID()
{
return ID;
}
public string getName()
{
return name;
}
public string getKind()
{
return kind;
}
public string getMaterial()
{
return material;
}
public string getStatus()
{
return status;
}
public void setStatus(string newStatus)
{
if (status != "")
status = newStatus;
}
public void setID(int newID)
{
if (newID > 0)
ID = newID;
}
public void setName(string newName)
{
if (name != "")
name = newName;
}
public void setKind(string newKind)
{
if (kind != "")
kind = newKind;
}
public void setMaterial(string newMaterial)
{
if (material != "")
material = newMaterial;
}
}
}
using System;
using Struna.Lab01.Task02.ClassLib;
namespace Task02.ConsoleApp
{
 class Program
 {
 static void Main(string[] args)
 {
 Furniture Furniture1 = new Furniture();
 Furniture1.setID(1);
 Furniture1.setName("Sofa");
 Furniture1.setKind("cushioned furniture");
 Furniture1.setMaterial("cloth");
 Furniture1.setStatus("new");
 Furniture1.Print();
 Furniture Furniture2 = new Furniture();
 Console.WriteLine("");
 Furniture2.setID(2);
 Furniture2.setName("Bed");
 Furniture2.setKind("bedroom furniture");
 Furniture2.setMaterial("natural wood");
 Furniture2.setStatus("used");
 Furniture2.Print();
 Furniture Furniture3 = new Furniture();
 Console.WriteLine("");
 Furniture3.setID(3);
 Furniture3.setName("Dining table");
 Furniture3.setKind("kitchen furniture");
 Furniture3.setMaterial("natural wood");
 Furniture3.setStatus("new");
 Furniture3.Print();
 }
 }
}

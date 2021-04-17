using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;
using Lab6_2;
using System.Collections.Generic;
namespace Lab6_1
{
 class Program
 {
 static void Main(string[] args)
 {
 string ask = "";
 List<PeopleInfo> user = new List<PeopleInfo>();
 using (WebClient client = new WebClient())
 {
 client.DownloadFile("https://randomuser.me/api", "PeopleInfo.json");
 }
 DataContractJsonSerializer formatter = new
DataContractJsonSerializer(typeof(List<PeopleInfo>));
 using (FileStream fs = new FileStream(@"PeopleInfo.json", FileMode.Open))
 {
 user = (List<PeopleInfo>)formatter.ReadObject(fs);
 }
 Func functional = new Func();
 for (; ; )
 {
 functional.PrintMenu();
 ask = Console.ReadLine();
 functional.HandleInput(ask, user, formatter);
 }
 }
 }
}

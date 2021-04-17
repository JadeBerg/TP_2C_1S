using System;
using Lab7_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lab7Test
{
 [TestClass]
 class RegeExTest
 {
 [TestMethod]
 public void CheckStringTrue()
 {
 Program p = new Program();
 string input = "#FF3421";
 Assert.AreEqual(true, p.CheckString(input));
 }
 [TestMethod]
 public void CheckStringFalse()
 {
 Program p = new Program();
 string input = "ff#ddee";
 Assert.AreEqual(false, p.CheckString(input));
 }
 }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab4_tp_bibl_
{
 public class RadiusVector
 {
 private int x1;
 private int y1;
 private double a;
 public int X1
 {
 get { return x1; }
 set { x1 = value; }
 }
 public int Y1
 {
 get { return y1; }
 set { y1 = value; }
 }
 public double Vector
 {
 get {
 a = (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)));
 return a;
 }
 }
 public RadiusVector()
 {
 }
 public RadiusVector(double vector)
 {
 }
 public RadiusVector(int x1)
 {
 this.x1 = x1;
 }
 public RadiusVector(int x1, int y1)
 {
 this.x1 = x1;
 this.y1 = y1;
 }
 public static explicit operator double(RadiusVector r)
 {
 return r.Vector;
 }
 public static implicit operator string(RadiusVector r)
 {
 string res = "";
 res += $"{r.Vector}";
 return res;
 }
 private int Compare(RadiusVector r)
 {
 if (Vector == r.Vector)
 return 0;
 if (Vector > r.Vector)
 return 1;
 else
 return -1;
 }
 public static RadiusVector operator +(RadiusVector r, double value)
 {
 return new RadiusVector(r.Vector + value);
 }
 public static RadiusVector operator -(RadiusVector r, double value)
 {
 return new RadiusVector(r.Vector - value);
 }
 public static RadiusVector operator *(RadiusVector r, double value)
 {
 double b1 = r.x1 * value;
 double b2 = r.y1 * value;
 return new RadiusVector((int)Math.Sqrt(Math.Pow(b1, 2) + Math.Pow(b2, 2)));
 }
 public static RadiusVector operator /(RadiusVector r, double value)
 {
 if(value == 0)
 {
 throw new DivideByZeroException();
 }
 double b1 = r.x1 * 1 / value;
 double b2 = r.y1 * 1 / value;
 return new RadiusVector((int)Math.Sqrt(Math.Pow(b1, 2) + Math.Pow(b2, 2)));
 }
 public static bool operator <(RadiusVector first, RadiusVector second)
 {
 return first.Compare(second) < 0;
 }
 public static bool operator >(RadiusVector first, RadiusVector second)
 {
 return first.Compare(second) > 0;
 }
 public static bool operator ==(RadiusVector first, RadiusVector second)
 {
 return first.Compare(second) == 0;
 }
 public static bool operator !=(RadiusVector first, RadiusVector second)
 {
 return first.Compare(second) != 0;
 }
 public static bool operator <=(RadiusVector first, RadiusVector second)
 {
 return first.Compare(second) <= 0;
 }
 public static bool operator >=(RadiusVector first, RadiusVector second)
 {
 return first.Compare(second) >= 0;
 }
 public virtual string GetInfo()
 {
 return $"Вектор длинной {Math.Round((Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1,
2))), 3)} c координатами ({x1}, {y1})";
 }
 }
}

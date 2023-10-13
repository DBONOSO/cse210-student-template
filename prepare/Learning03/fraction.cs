using System;
public class Fraction
{
 private int _bottom;
 private int _top;

 public Fraction()
{
 _bottom = 1;
 _top = 1;
}

 public Fraction(int whole)
 {
  _bottom = 1;
  _top = whole;
 }

 public Fraction(int bottom, int top)
 {
  _bottom = bottom;
  _top = top;

 }

 public string GetFractionString()
 {
  string text = $"{_top}/{_bottom}";
  return text;
 }
 public double GetDecimalValue()
 {
  return (double)_top / (double)_bottom;
 }
}
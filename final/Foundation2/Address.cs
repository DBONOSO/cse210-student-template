using System;

class Address
{
 string _address = "";
 private bool _is;

 public Address()
 {

 }

 public Address(string address, bool isA)
 {
  _address = address;
  _is = isA;
 }

 public string GetAddress()
 {
  return _address;
 }

 public void SetAddress()
 {
  Console.WriteLine("Provide the address");
  string userResp = Console.ReadLine();
  _address = userResp;
 }

 public void SetA(bool isA)
 {
  _is = isA;
 }
 public bool GetA()
 {
  return _is;
 }
}
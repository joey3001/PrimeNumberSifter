using System;
using System.Collections.Generic;
using PrimeNumberSift;
public class Program
{
  public static void Main()
  {
    PrimeSift primeNumberTest = new PrimeSift(); 
    Console.WriteLine("Enter a Number");
    string input = Console.ReadLine();
    int inputNumber = int.Parse(input);
    primeNumberTest.sifter(inputNumber);
    for (int i = 1; i <= primeNumberTest.primeNumberList.Count; i++) {
      Console.Write(primeNumberTest.primeNumberList[i-1]);
      if (i != primeNumberTest.primeNumberList.Count) {
        Console.Write(", ");
      }
    }
  }
}
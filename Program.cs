using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace First_Bank_of_Suncoast
{
  class Program
  {


    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the First Bank of Suncoast!");

      var reader = new StreamReader("accounts.csv");
      var data = reader.ReadToEnd();

      Console.WriteLine("Here is your Account Summary:");
      //should be able to see totals in my savings acct and checking acct
      Console.WriteLine($"Savings Account:...   Checking Account:...");



    }
  }
}
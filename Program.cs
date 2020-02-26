using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;

namespace First_Bank_of_Suncoast
{
  class Program
  {


    static void Main(string[] args)
    {
      Console.Clear();

      Console.WriteLine("Welcome to the First Bank of Suncoast!");

      var reader = new StreamReader("accounts.csv");
      var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);

      bool appClosed = false;
      while (!appClosed)
      {

        var input = Console.ReadLine().ToLower();

        var writer = new StreamWriter("accounts.csv");
        var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
        writer.Flush();

        Console.WriteLine("Here is your Account Summary:");
        //should be able to see totals in my savings acct and checking acct
        Console.WriteLine($"Savings Account:...   Checking Account:...");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("\n(Deposit - D) (Withdraw - W) (Transfer - T)");

        if (input == "d")
        {
          Console.WriteLine("Which Account would you like to deposit into? Checking (C) or Savings (S)");
        }
        else
        {
          appClosed = true;
        }
      }

    }
  }
}
using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
      citiesList.Add("Hyderabad");
      foreach(string cities in citiesList)
      {
        Console.WriteLine(cities);
      }
      
    }
  }
}

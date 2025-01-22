using System;

namespace DoWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      do
      {
        buttonClick = true;
        Console.WriteLine("Alarm Ringing");
      }
      while(!buttonClick);
      Console.WriteLine("Time for a five minute break");
    }
  }
}
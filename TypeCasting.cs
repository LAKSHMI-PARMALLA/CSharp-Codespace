using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");
            // Attempt 2: use explicit conversion
       int faveNumber = (int)Console.ReadLine();
      
      // Attempt 3: use Convert method
      int faveNumber = Convert.ToInt32(Console.ReadLine());

      //int faveNumber = Console.ReadLine(Conver.ToInt32());
      // Turn that answer into an int



    }
  }
}

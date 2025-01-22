using System;

namespace BuiltInMethods
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      int positionThreeStar = Array.IndexOf(ratings, 3);
      Console.WriteLine($"Song number {positionThreeStar + 1} is rated three stars.");
      Array.Reverse(summerStrut);
      string newFirst = summerStrut[0];
      string newLast = summerStrut[7];
      Console.WriteLine($"First song is {newFirst}");
      Console.WriteLine($"Last song is {newLast}");

      Array.Sort(summerStrut);
      string firstSong = summerStrut[0];
      string lastSong = summerStrut[7];
      Console.WriteLine($"First song is {firstSong}");
      Console.WriteLine($"Last song is {lastSong}");
    }
  }
}

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Beginning of the story";
      string middle = "Middle of the story";
      string end = "End of the story";

      // Concatenate the string and the variables
      string story = beginning + "\n" + middle + "\n" + end;

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time,";
      string middle = "The kid climbed a tree";
      string end = "Everyone lived happily ever after.";

      // Interpolate the string and the variables
      string story = $"{beginning} {middle} A monkey helped the kid climb down the tree safely and {end}";

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}

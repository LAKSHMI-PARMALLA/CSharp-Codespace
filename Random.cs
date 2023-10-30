public class MyClass
{
    public static void Main(String[] args)
    {
        Random dice = new Random();
        int roll = dice.Next(1, 7);
        Console.WriteLine(roll);
    }

}

public class Orders 
{
    public static void Main(string[] args)
    {
        string[] OrderIDs = { "B123" ,"C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        foreach (string orderID in OrderIDs)
        {
            if(orderID.Contains("B"))
            {
                Console.WriteLine(orderID);
            }
        }
    }
}
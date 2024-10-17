class Program
{
    static void Main()
    {
        try
        {
            string[] name= null;
            Console.WriteLine(name[0]); 
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(" The array is not initialized.");
        }
    }
}


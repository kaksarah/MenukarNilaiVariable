public class Program
{
    public static void Main(string[] args)
    {
        int a = 15;
        int b = 20;

        a = a + b;
        b = a - b;
        a = a - b;
        

        Console.Write("{0} - {1}", a, b);
    }
}

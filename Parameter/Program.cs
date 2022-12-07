namespace Parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterManager<string> isimler = new ParameterManager<string>();
            isimler.Add("");

            List<string> list = new List<string>();
            Console.WriteLine(list);
            Console.WriteLine("Hello, World!");
        }
    }
}
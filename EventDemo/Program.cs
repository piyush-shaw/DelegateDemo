using EventDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Demo.add += new DelEventHandler(Demo.India);
        Demo.add += new DelEventHandler(Demo.USA);
        Demo.add += new DelEventHandler(Demo.England);
        //Demo.InvokeAdd();
        Console.WriteLine("************Event Handling****************");
        EventHandling.ImplementEvent();
        Console.ReadKey();
    }
}
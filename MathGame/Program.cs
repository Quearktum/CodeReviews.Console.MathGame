using MathGame;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = Helper.GetName();
        var date = DateTime.Now;

        var menu = new Menu();

        menu.Init(name, date);
    }
}
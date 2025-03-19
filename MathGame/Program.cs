using MathGame;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = Helper.GetName();
        var date = DateTime.Now;

        var menu = new Menu();
        var games = new List<string>();

        menu.Init(name, date);
    }
}
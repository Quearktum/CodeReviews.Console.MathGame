using MathGame;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Sources;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = Helper.GetName();
        var date = DateTime.Now;
        bool isGameOn = true;

        var menu = new Menu();
        var games = new List<string>();

        menu.Init(name, date);
    }
}
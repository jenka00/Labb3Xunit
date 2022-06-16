using System;

namespace Labb3Xunit
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu myMenu = new Menu();
            Console.WriteLine("Välkommen till miniräknaren.");
            myMenu.ShowMenu();
        }
    }
}

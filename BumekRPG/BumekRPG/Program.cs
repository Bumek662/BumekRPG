using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BumekRPG.Class;
namespace BumekRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SharpRPG";
            Console.Write("Nazwa: ");
            Character.Nick = Console.ReadLine();
            Actions.SetDefault();
            Console.Clear();
            Console.WriteLine("Witaj " + Character.Nick + "!\nWpisz POMOC aby uzyskac pomoc.");
            while (true)
            {
                Console.Write(":");
                Actions.Command(Console.ReadLine().ToLower());
            }

        }
    }
}

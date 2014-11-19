using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumekRPG.Class
{
    public class Actions
    {
        public static void Command(string Command)
        {
            if (Command == "pomoc")
            {
                Console.WriteLine("----------------------------------- \nPomoc - Wyświetla pomoc\nStatus - Pokazuje twój status gry\nPoluj - Polowanie\nSklep - Otwiera sklep\nWyczysc - czysci konsole.");
                Console.WriteLine("----------------------------------- ");
            }

            if (Command == "poluj")
            {
                Console.Clear();
                Hunting.Hunt();
            }
            if (Command == "sklep")
            {
                Shop.OpenShop();
            }

            if (Command == "status")
            {
                Console.Clear();
                Console.WriteLine("----------------------------------- \nNick: " + Character.Nick + " (" + Character.Lvl + " lvl)\nExp: " + Character.Exp + "/" + Character.ExpToLvl + "\nPieniadze: " + Character.Money + "$\nHP: " + Character.HP + "/" + Character.MaxHP + "\nAD: " + Character.AD + "\n----------------------------------- ");
            }

            if (Command == "wyczysc")
            {
                Console.Clear();
            }
        }




        public static void LevelUP() // Metoda odpowiadająca za zdobycie lvl'a.
        {
            if (Character.ExpToLvl <= Character.Exp)
            {
                Character.Lvl += 1;
                Character.MaxHP += 2;
                Character.ExpToLvl *= 2;
                Character.AD += 2;
                Console.WriteLine("Brawo!\nAwansowałeś na lvl " + Character.Lvl + "!");
                int Reward = (Character.Lvl * 10) + 5;
                Character.Money += Reward;
                Console.WriteLine("Nagroda: " + Reward + "$");
            }
        }

        public static void SetDefault()
        {
            Console.Title = "SharpRPG - " + Character.Nick;
            Character.Lvl = 1;
            Character.HP = 100;
            Character.MaxHP = 100;
            Character.AD = 6;
        }

    }
}

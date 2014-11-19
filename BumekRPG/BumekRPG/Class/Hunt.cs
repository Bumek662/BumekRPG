using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumekRPG.Class
{
    class Hunting
    {
        public static void Hunt()
        {
            Console.Write("Wybierz przeciwnika: \n" + Monsters.ListOfMonsters + "\n0) Wyjscie\n:");
            string Choose = Console.ReadLine();
            if (Choose == "0")
            {
                return;
            }
            Console.Clear();
            try
            {
                int MonsterID = Convert.ToInt32(Choose);
                Monsters.Monster(MonsterID);
            }
            catch (SystemException)
            {
                Console.Clear();
                Console.WriteLine("Wprowadzone ID przeciwnika jest nieprawidlowe!");
                Hunt();
                return;

            }
            if (Character.Lvl > Monsters.Monster_MaxLvlDifference + Monsters.Monster_Lvl || Character.Lvl < Monsters.Monster_Lvl)
            {
                Console.Clear();
                Console.WriteLine("Wskazany przeciwnik jest zbyt silny lub zbyt słaby.");
                Hunt();
                return;
            }

            int DMG;
            int Exp;
            int Drop;
            bool Death = false;
            string Status = "unknown";
            Console.WriteLine("Nazwa przeciwnika: " + Monsters.Monster_Name + "\nPoziom: " + Monsters.Monster_Lvl + "\nZdrowie: " + Monsters.Monster_HP + "\nAD: " + Monsters.Monster_AD);
            Console.WriteLine("Walka rozpoczyna się!\nTwoje HP: " + Character.HP + "/" + Character.MaxHP + "\nHP Przeciwnika: " + Monsters.Monster_HP + "\n\n");
            Random Random = new Random();

            while (Status == "unknown")
            {
                DMG = Random.Next(Character.AD - 1, Character.AD + 1);
                Character.HP -= DMG;
                Console.WriteLine("Przeciwnik zadał ci " + DMG + " obrażeń! Pozostało ci " + Character.HP + "/" + Character.MaxHP + " HP!");
                Console.ReadKey();
                if (0 >= Character.HP)
                {
                    Status = "Lose";
                    Death = true;
                }
                if (Death == false)
                {
                    DMG = Random.Next(Character.AD - 1, Character.AD + 1);
                    Monsters.Monster_HP -= DMG;
                    Console.WriteLine("Zadajesz przeciwnikowi " + DMG + " obrażeń! Pozostało mu " + Monsters.Monster_HP + " HP!");
                    Console.ReadKey();
                    if (0 >= Monsters.Monster_HP)
                    {
                        Status = "Win";
                    }
                }
            }

            if (Status == "Win") // Jezeli walka zostala wygrana
            {
                // Tutaj bedzie dodawanie expa
                Console.Clear();
                Drop = Random.Next(1, Monsters.Monster_MaxDrop);
                Character.Money += Drop;
                Exp = Random.Next(Monsters.Monster_Exp - 10, Monsters.Monster_Exp + 10);
                Character.Exp += Exp;
                Console.WriteLine("Wygrałeś walkę!\nTwoje zdrowie: " + Character.HP + "/" + Character.MaxHP + "\nNagroda: " + Drop + "$" + "\nTwój EXP: " + Character.Exp + "/" + Character.ExpToLvl);
                Actions.LevelUP();
            }

            if (Status == "Lose") // Jezeli walka zostala przegrana
            {
                Console.Clear();
                Console.WriteLine("Niestety, przegrales..\nPrzeciwnikowi zostało " + Monsters.Monster_HP + " HP, jednak cię zmiażdzył.\nKliknij przycisk by zacząć od nowa.");
                Console.ReadKey();
                Actions.SetDefault();
            }


        }
    }
}

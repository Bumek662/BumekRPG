using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumekRPG.Class
{
    public class Shop
    {
        public static void OpenShop()
        {
            string ListOfItems = "1) Mały eliksir (+25% zdrowia) - 50$\n2) Średni eliksir (+60% zdrowia) - 80$\n3) Duży eliksir (+100% zdrowia) - 140$" + "\nTwoje pieniądze: " + Character.Money + "$\n:";
            Console.WriteLine("--------------------------\n----------Sklep-----------\n--------------------------"); // Naglowek
            Console.Write(ListOfItems); // Przedmioty
            int ChosenItem = Convert.ToInt32(Console.ReadLine());
            BuyItem(ChosenItem);

        }


        public static void BuyItem(int ItemID)
        {
            int Item_Cost;
            if (ItemID == 1)
            {
                Item_Cost = 25;
                if (Character.HP != Character.MaxHP)
                {
                    if (Character.Money >= Item_Cost)
                    {
                        Character.Money -= Item_Cost;
                        if (Character.HP + Character.MaxHP / 4 <= Character.MaxHP)
                        {
                            int Counted = Character.MaxHP / 4;
                            Character.HP += Counted;
                            Console.WriteLine("Poprawnie zakupiłeś mały eliksir!\nZostałeś uleczony o 25% maksymalnego zdrowia (" + Counted + ").\nAktualny stan konta: " + Character.Money);
                        }
                        else
                        {
                            if (Character.HP != Character.MaxHP)
                            {
                                Console.WriteLine("Poprawnie zakupiłeś mały eliksir!\nZostałeś uleczony do 100% zdrowia nie wykorzystując całego eliksiru.\nAktualny stan konta: " + Character.Money);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Masz za mało pieniędzy.");
                    }
                }
                else
                {
                    Console.WriteLine("Jesteś zdrowy!");
                }
            }

            // ############# Koniec itemu o ID 1. #############

            if (ItemID == 2)
            {
                Item_Cost = 80;
                if (Character.HP != Character.MaxHP)
                {
                    if (Character.Money >= Item_Cost)
                    {
                        Character.Money -= Item_Cost;
                        if (Character.HP + Character.MaxHP / 10 * 6 <= Character.MaxHP)
                        {
                            int Counted = Character.MaxHP / 10 * 6;
                            Character.HP += Counted;
                            Console.WriteLine("Poprawnie zakupiłeś mały eliksir!\nZostałeś uleczony o 60% maksymalnego zdrowia (" + Counted + ").\nAktualny stan konta: " + Character.Money);
                        }
                        else
                        {
                            if (Character.HP != Character.MaxHP)
                            {
                                Console.WriteLine("Poprawnie zakupiłeś średni eliksir!\nZostałeś uleczony do 100% zdrowia nie wykorzystując całego eliksiru.\nAktualny stan konta: " + Character.Money);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Masz za mało pieniędzy.");
                    }
                }
                else
                {
                    Console.WriteLine("Jesteś zdrowy!");
                }
            } 

            // ############# Koniec itemu o ID 2. #############

            if (ItemID == 3)
            {
                Item_Cost = 140;
                if (Character.HP != Character.MaxHP)
                {
                    if (Character.Money >= Item_Cost)
                    {
                        Character.Money -= Item_Cost;
                        Character.HP = Character.MaxHP;
                        Console.WriteLine("Poprawnie zakupiłeś duży eliksir!\nZostałeś uleczony do 100% zdrowia.\nAktualny stan konta: " + Character.Money);
                    }
                    else
                    {
                        Console.WriteLine("Masz za mało pieniędzy.");
                    }
                }
                else
                {
                    Console.WriteLine("Jesteś zdrowy!");
                }
            }

            // ############# Koniec itemu o ID 3. #############

        }

    }
}

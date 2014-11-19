using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumekRPG.Class
{
    class Monsters
    {
        public static string ListOfMonsters = "1) Królik (1 lvl)\n2) Pies (2 lvl)\n3) Wilk (4 lvl)";
        public static string Monster_Name { get; set; }
        public static int Monster_AD { get; set; }
        public static int Monster_HP { get; set; }
        public static int Monster_Lvl { get; set; }
        public static int Monster_Exp { get; set; }
        public static int Monster_MaxLvlDifference { get; set; }
        public static int Monster_MaxDrop { get; set; }

        public static void Monster(int MonsterID)
        {

            if (MonsterID == 1)
            {
                Monster_Name = "Krolik";
                Monster_Lvl = 1;
                Monster_AD = 4;
                Monster_HP = 10;
                Monster_MaxLvlDifference = 0;
                Monster_MaxDrop = 15;
                Monster_Exp = 25;
            }

            if (MonsterID == 2)
            {
                Monster_Name = "Pies";
                Monster_Lvl = 2;
                Monster_AD = 7;
                Monster_HP = 15;
                Monster_MaxLvlDifference = 1;
                Monster_MaxDrop = 30;
                Monster_Exp = 40;
            }

            if (MonsterID == 3)
            {
                Monster_Name = "Wilk";
                Monster_Lvl = 4;
                Monster_AD = 10;
                Monster_HP = 24;
                Monster_MaxLvlDifference = 2;
                Monster_MaxDrop = 45;
                Monster_Exp = 75;
            }

        }
    }
}

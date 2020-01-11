using System;
using System.Collections.Generic;

namespace CriticalRoleSimulator
{

    /* class Player
    {
        public string FirstName;
        public string LastName;
        public string PlayerRace;
        public string PlayerClass;
        public int Str;
        public int Dex;
        public int Con;
        public int Int;
        public int Wis;
        public int Cha;
        private int HP;
        public int GetSetHP
        {
            get
            {
                return HP;
            }
            set
            {
                HP = value;
            }
        }
    } */










    class Program
    {

        public static int RollStat()
        {
            Random d6 = new Random();
            List<int> OneStatRolls = new List<int>();
            int MinRoll = 0;
            for (int i = 0; i < 4; i++)
            {
                int roll = d6.Next(1, 7);
                if (i == 0)
                {
                    MinRoll = roll;
                }
                else
                {
                    if (roll < MinRoll)
                    {
                        MinRoll = roll;
                    }
                }
                OneStatRolls.Add(roll);
            }
            OneStatRolls.Remove(MinRoll);
            int sum = 0;
            foreach (int item in OneStatRolls)
            {
                sum += item;
            }
            return sum;
        }

        public static int[] RollAllStats()
        {
            Console.WriteLine("Let's roll your ability score stats!");
            Console.WriteLine("If you wind up with a final stat less than 8, it will be defaulted to 8.");
            int[] FinalList = new int[6];
            for (var x = 0; x < 6; x++){
                int stat = RollStat();
                if (stat < 8){
                    stat = 8;
                }
                FinalList[x] = stat;
            }
            foreach (int item in FinalList){
                Console.WriteLine(item);
            }
            return FinalList;
        }

        static void Main(string[] args)
        {
            RollAllStats();
        }
    }
}

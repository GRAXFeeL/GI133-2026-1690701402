/*
 * Student ID : 1690701402
 * Name       : Natasak Khamchaisri
 * Section    : 129B
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss} \n");
            int hpParent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpParent}% \n");
            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp -= 60;
            Console.WriteLine($"\n===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP : {currentHp}/{maxHp}");
            hpParent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpParent}%");

            static void HEROs()
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine("\n\n===== HERO STATUS: INITIAL =====");

                    int CharacterNumber = 1;
                    string HeroName = "";
                    float AttackPower = 0;
                    int Level = 0;
                    int MaxHp = 0;

                    while (i < 5)
                    {
                        if (CharacterNumber == 1)
                        {
                            HeroName = "IDK";
                            Level = 2; MaxHp = 115; AttackPower = 10; int stamina = 80; int IsHeroNumber = 1;
                            Console.WriteLine($"\n\nHeroNumber: {IsHeroNumber} \nHero Name: {HeroName} \nLevel: {Level} \nAttack Power: {AttackPower} \nStamina: {stamina} \nMax HP: {MaxHp}");
                            CharacterNumber += 1;
                        }
                        else if (CharacterNumber == 2)
                        {
                            HeroName = "ImayBeKnow";
                            Level = 3; MaxHp = 75; AttackPower = 30; int stamina = 50; int IsHeroNumber = 2;
                            Console.WriteLine($"\n\nHeroNumber: {IsHeroNumber} \nHero Name: {HeroName} \nLevel: {Level} \nAttack Power: {AttackPower} \nStamina: {stamina} \nMax HP: {MaxHp}");
                            CharacterNumber += 1;
                        }
                        else if (CharacterNumber == 3)
                        {
                            HeroName = "ThatWay";
                            Level = 10; MaxHp = 500; AttackPower = 250; int stamina = 700; int IsHeroNumber = 3;
                            Console.WriteLine($"\n\nHeroNumber: {IsHeroNumber} \nHero Name: {HeroName} \nLevel: {Level} \nAttack Power: {AttackPower} \nStamina: {stamina} \nMax HP: {MaxHp}");
                            CharacterNumber += 1;
                        }
                        else if (CharacterNumber == 4)
                        {
                            HeroName = "I known";
                            Level = 5; MaxHp = 305; AttackPower = 100; int stamina = 400; int IsHeroNumber = 4;
                            Console.WriteLine($"\n\nHeroNumber: {IsHeroNumber} \nHero Name: {HeroName} \nLevel: {Level} \nAttack Power: {AttackPower} \nStamina: {stamina} \nMax HP: {MaxHp}");
                            CharacterNumber += 1;
                        }
                        else if (CharacterNumber == 5)
                        {
                            HeroName = "Unknown";
                            Level = 1; MaxHp = 40; AttackPower = 3; int stamina = 25; int IsHeroNumber = 5;
                            Console.WriteLine($"\n\nHeroNumber: {IsHeroNumber} \nHero Name: {HeroName} \nLevel: {Level} \nAttack Power: {AttackPower} \nStamina: {stamina} \nMax HP: {MaxHp}");
                            CharacterNumber += 1;
                        }
                    }
                }
                
            }
            HEROs();
        }
    }
}

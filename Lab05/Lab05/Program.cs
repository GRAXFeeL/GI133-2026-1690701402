namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Hero Stats
            Console.Write("Hero HP: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero ATK: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero DEF: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            //Monster Stats
            Console.Write("\nMonster HP: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster ATK: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster DEF: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);


            //Check for valid input
            bool heroInputValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monsterInputValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($">>Hero stats valid: {heroInputValid} \n>>Monster stats valid: {monsterInputValid}");


            //Hero drinks potion before the fight(compond assignemt: +=)
            int potionHeal = 14;
            //HeroHp = HeroHp + potionHeal ผลคือ 114
            //HeroHp += potionHeal ผลคือ 114 การคำนวนเหมือนกันแต่สั้นกว่า
            heroHp += 14; //Hero ดื่ม Hp Potion
            Console.WriteLine($"\nHero drinks a potion, Healing {potionHeal} HP. Hero HP is now {heroHp}");

            int normalDamage = Math.Max(0, heroAtk - monDef); //โจมตีปกติโดยการ
            Console.WriteLine($"Normal attack deals {normalDamage} DMG.");

            int powerDamage = Math.Max(0, (heroAtk * 2) - monDef); //โจมตีแบบพลังโจมตีคูณสอง
            Console.WriteLine($"Power attack deals {powerDamage} DMG.");

            int  counterDamage = Math.Max(0, monAtk - heroDef); //โจมตีแบบ Counter
            Console.WriteLine($"Counter attack deals {counterDamage} DMG.");

            Random Gambling = new Random();
            int gamble = Gambling.Next(1, 101); //สุ่มตัวเลข 1-100
            bool isCrit = gamble <= 10; // 10% chance for critical hit
            int CritDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage;
            Console.WriteLine($"Crit damage gamble:{gamble} (Crit?: {isCrit}) \nIf critical, normal attack would deal: {CritDamage} DMG");
        }
    }
}

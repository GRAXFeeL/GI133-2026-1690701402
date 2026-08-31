namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Boss Stats
            Console.WriteLine($"===== KIRIN SAVE CONVERTER =====\n\n\n NAME: {bossName}\n RANK: {rank}\n LEVEL: {level} / {MaxLevel}\n HP: {currentHp} / {maxHp}\n ATTACK POWER: {attackPower}\n CRIT MULTIPLIER: {critMultiplier}\n IS BOSS: {isBoss}");
            
            //Implicit conversion HP (int) -->> duble
            double currentHpDouble = currentHp;
            Console.WriteLine($"\n\n ---- IMPLICIT CONVERSION: HP as double ----\n HP (double): {currentHpDouble}");

            // Calculate Percent as double
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"\n\n----- Exact HP Percent (no integer truncation) -----\nHP Percent (exact): {hpPercentExact}%");

            // Explicit casting attack power (float) -->> int
            
            // Cast vs Convert: Crit Multiplier

        }
    }
}

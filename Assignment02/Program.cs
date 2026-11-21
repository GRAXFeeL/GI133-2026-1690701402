/* Student ID : 1690701402
Name          : Natasak Khamchisri
Section       : 129B
No.           : 16
Course        : GI113 Computer Programming(GI)
*/
using System;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Material = "Gold";
            const double SmeltRate = 0.4;
            const double SalvageRate = 0.7;
            const double MaxBatch = 1000;

            Console.WriteLine("===================================");
            Console.WriteLine("{<    -=<{[Gilded Forge]}>=-     >}");
            Console.WriteLine("===================================");
            Console.WriteLine($"=> {Material} Ore Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> Key < S > for Smelt [Gold Ore >> Gold Ingot]");
            Console.WriteLine("=> Key < B > for Breakdown [Gold Ingot >> Gold Ore]");

            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine();
            bool isMenuParsed = char.TryParse(menuInput, out char menu);

            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine();
            bool isAmountParsed = double.TryParse(amountInput, out double amount);

            if (isAmountParsed && amount > 0 && amount <= MaxBatch)
            {
                if (isMenuParsed && (menu == 'S' || menu == 's'))
                {
                    double ingot = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {Material} Ore = {ingot:F2} {Material} Ingot");
                }
                else if (isMenuParsed && (menu == 'B' || menu == 'b'))
                {
                    double ore = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {Material} Ingot = {ore:F2} {Material} Ore");
                }
                else
                {
                    Console.WriteLine("Error: invalid menu. Please key S or B only.");
                }
            }
            else
            {
                Console.WriteLine($"Error: invalid amount. Enter a number greater than 0 and not more than {MaxBatch}.");
            }
        }
    }
}
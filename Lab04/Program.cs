/*
* Student ID : 1690701402
* Name       : Natasak Khamchaisri
* Section    : 129B
* No.        : 16
* Course     : GI113 Computer Programming (GI)
*/

// ---------- Screen 1: Character Creation ----------
using System;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION      |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine();

            // ---------- Screen 2: Item Shop ----------
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP          |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine();

            // ---------- Screen 3: Set Volume ----------
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME          |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine();

            // ---------- Screen 4: New Save File ----------
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE        |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
        }
    }
}
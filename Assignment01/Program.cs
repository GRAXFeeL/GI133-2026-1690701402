/* Student ID : 1690701402
Name          : Natasak Khamchisri
Section       : 129B
No.           : 16
Course        : GI113 Computer Programming(GI)
*/

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Flow pvp server (Minecraft)";

            var pvpType = "Mace Queue";
            var tier = "LT2";
            var scoreGrade = 'C';
            var playTimes = "2h";
            int matchesPlayed = 42;
            float hitAccuracy = 0.65f;
            double winRate = 50.8;
            bool isMatchFound = true;

            double matches_PlayersAsDouble = matchesPlayed;

            int winRatesTruncated = (int)winRate;
            int winRatesRounded = Convert.ToInt32(winRate);

            Console.WriteLine("=========================================");
            Console.WriteLine($"||  // {GameTitle} \\\\  ||");
            Console.WriteLine("=========================================");
            Console.WriteLine("-_|\\|         {Player Stats}        |/|_-");
            Console.WriteLine($">>  Pvp type        : {pvpType}         ");
            Console.WriteLine($">>  Tier            : {tier}            ");
            Console.WriteLine($">>  Score           : [{scoreGrade}]    ");
            Console.WriteLine($">>  Play times      : {playTimes}       ");
            Console.WriteLine($">>  Matches players : {matchesPlayed}   ");
            Console.WriteLine($">>  hit Accuracy    : {hitAccuracy}     ");
            Console.WriteLine($">>  Found the match : {isMatchFound}    ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("          [ Conversion display ]         ");
            Console.WriteLine($">>  Matches players (implicit) : {matches_PlayersAsDouble}");
            Console.WriteLine($">>  WinRates                   : {winRate}");
            Console.WriteLine($">>  WinRates cast (cuts off)   : {winRatesTruncated}");
            Console.WriteLine($">>  WinRates Convert (rounds)  : {winRatesRounded}");
            Console.WriteLine("=========================================");
        }
    }
}
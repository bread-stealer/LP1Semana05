using System;
using Spectre.Console;

namespace DungeonStats
{
    public class Program
    {
        private static int Damage(int attack)
            => attack;
        private static int Damage(int attack, int defense)
            => Math.Max(attack - defense, 0);

        private static int CriticalHit(int damage)
            => damage <= 0 ? 0 : 1 + CriticalHit(damage - 1);
        private static void Main(string[] args)
        {
            int attack = int.Parse(args[0]);
            int defense = args.Length >= 2 ? int.Parse(args[1]) : 2;
            int dmgNoDefense   = Damage(attack);
            int dmgWithDefense = Damage(attack, defense);
            
            int critHit        = CriticalHit(dmgWithDefense);
            
            Table table = new();
            table.AddColumn("Operation");
            table.AddColumn("Result");
            table.AddRow($"Damage({attack})",              $"{dmgNoDefense}");
            table.AddRow($"Damage({attack}, {defense})",   $"{dmgWithDefense}");
            table.AddRow($"CriticalHit({dmgWithDefense})", $"{critHit}");
            
            AnsiConsole.Write(table);
        }
    }
}
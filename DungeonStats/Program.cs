using System;

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
            
        }
    }
}

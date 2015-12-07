using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;
using TheSlum.Items;

namespace TheSlum.Characters
{
    public class Healer : AdvancedCharacter, IHeal
    {
        //Has default Health points of 75, Defense points of 50, Healing points of 60 and Range of 6.

        private const int DefaultHealthPoints = 75;
        private const int DefaultDefensePoints = 50;
        private const int DefaultHealingPoints = 60;
        private const int DefaultRange = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.HealingPoints = DefaultHealingPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            //implements IHeal and interacts by healing alive characters from his/her own team. Always picks the target with the least Health points (cannot target self). 
            var target = targetsList
                .Where(x => x!=this)
                .Where(x => x.IsAlive)
                .Where(x => x.Team == this.Team)
                .OrderBy(x => x.HealthPoints)
                .FirstOrDefault();

            return target;
        }

        public override string ToString()
        {
            return base.ToString() + " Healing: " + this.HealingPoints;
        }

        public int HealingPoints { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;
using TheSlum.Items;

namespace TheSlum.Characters
{
    public class Mage : AdvancedCharacter, IAttack
    {
        private const int DefaultHealthPoints = 150;
        private const int DefaultDefensePoints = 50;
        private const int DefaultAttackPoints = 300;
        private const int DefaultRange = 5;

        public Mage(string id, int x, int y, Team team) 
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.AttackPoints = DefaultAttackPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            //attacking alive characters from the other team. Always picks the last target
            var target = targetsList
                .Where(x => x.IsAlive)
                .LastOrDefault(x => x.Team != this.Team);
            return target;
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }

        public override string ToString()
        {
            return base.ToString() + "Attack: " + this.AttackPoints;
        }

        public int AttackPoints { get; set; }
    }
}

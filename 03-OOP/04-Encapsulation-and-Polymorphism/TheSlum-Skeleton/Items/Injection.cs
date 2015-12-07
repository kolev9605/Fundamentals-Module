namespace TheSlum.Items
{
    public class Injection : Bonus
    {
        private const int DefaultHealthEffect = 200;
        private const int DefaultDefenseEffect = 0;
        private const int DefaultAttackEffect = 0;
        private const int TimeoutTurns = 4;

        public Injection(string id) 
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            this.Timeout = TimeoutTurns;
            this.Countdown = TimeoutTurns;
        }
    }
}

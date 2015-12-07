namespace TheSlum.Items
{
    public class Pill : Bonus
    {
        private const int DefaultHealthEffect = 0;
        private const int DefaultDefenseEffect = 0;
        private const int DefaultAttackEffect = 100;
        private const int TimeoutTurns = 1;

        public Pill(string id)
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            this.Timeout = TimeoutTurns;
            this.Countdown = TimeoutTurns;
        }
    }
}

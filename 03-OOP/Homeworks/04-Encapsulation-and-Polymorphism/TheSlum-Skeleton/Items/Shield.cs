namespace TheSlum.Items
{
    public class Shield : Item
    {
        private const int DefaultHealthEffect = 0;
        private const int DefaultDefenseEffect = 50;
        private const int DefaultAttackEffect = 0;

        //Shield – Item with HealthEffect of 0, DefenseEffect of 50 and AttackEffect of 0
        public Shield(string id)
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
        }
    }
}

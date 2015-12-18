namespace TheSlum.Items
{
    public class Axe : Item
    {
        private const int DefaultHealthEffect = 0;
        private const int DefaultDefenseEffect = 0;
        private const int DefaultAttackEffect = 75
            ;
        //Axe – Item with HealthEffect of 0, DefenseEffect of 0 and AttackEffect of 75.
        public Axe(string id) 
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
        }
    }
}

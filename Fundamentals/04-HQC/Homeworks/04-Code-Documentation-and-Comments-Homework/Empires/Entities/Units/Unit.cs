namespace Empires.Entities.Units
{
    using Interfaces;
    public abstract class Unit : IUnit
    {
        protected Unit(int damage, int health)
        {
            this.Damage = damage;
            this.Health = health;
        }

        public int Damage { get; }
        public int Health { get; }
    }
}

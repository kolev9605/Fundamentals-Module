namespace Empires.Entities.Units
{
    public class Archer : Unit
    {
        private const int ArcherDefaultDamage = 7;
        private const int ArcherDefaultHealth = 25;

        public Archer() 
            : base(ArcherDefaultDamage, ArcherDefaultHealth)
        {
        }
    }
}

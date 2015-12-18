namespace Empires.Entities.Units
{
    public class Swordsman : Unit
    {
        private const int SwordsmanDefaultDamage = 13;
        private const int SwordsmanDefaultHealth = 40;

        public Swordsman() 
            : base(SwordsmanDefaultDamage, SwordsmanDefaultHealth)
        {
        }
    }
}

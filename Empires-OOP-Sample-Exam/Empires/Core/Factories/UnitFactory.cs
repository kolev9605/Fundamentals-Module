namespace Empires.Core.Factories
{
    using System;
    using Entities.Units;
    using Interfaces;
    class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "Archer":
                    return new Archer();
                case "Swordsman":
                    return new Swordsman();
                default:
                    throw new ArgumentException("Unit not supplied");
            }
        }
    }
}

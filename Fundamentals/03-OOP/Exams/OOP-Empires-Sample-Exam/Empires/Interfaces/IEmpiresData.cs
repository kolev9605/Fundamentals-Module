namespace Empires.Interfaces
{
    using System.Collections;
    using System.Collections.Generic;
    using Enums;

    public interface IEmpiresData
    {
        IDictionary<ResourceType, int> Resources { get; } // resource type -> quantity
        IEnumerable<IBuilding> Buildings { get; }
        IDictionary<string, int> Units { get; }

        void AddUnit(IUnit unit);
        void AddBuilding(IBuilding building);
        void AddResource(IResource resource, int quantity);

    }
}

namespace Empires.Entities
{
    using Enums;
    using Interfaces;
    class Resource : IResource
    {
        public Resource(ResourceType resourceType, int quantity)
        {
            this.ResourceType = resourceType;
            this.Quantity = quantity;
        }

        public ResourceType ResourceType { get; }
        public int Quantity { get; }
    }
}

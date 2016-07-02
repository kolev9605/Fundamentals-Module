namespace Empires.Core.Factories
{
    using Entities;
    using Enums;
    using Interfaces;

    public class ResourceFactory : IResourceFactory
    {
        public IResource CreateResource(ResourceType type, int quantity)
        {
            return new Resource(type, quantity);
        }
    }
}

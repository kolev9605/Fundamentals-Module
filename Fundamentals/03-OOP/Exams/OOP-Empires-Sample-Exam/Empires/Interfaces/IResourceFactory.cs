namespace Empires.Interfaces
{
    using Enums;

    public interface IResourceFactory
    {
        IResource CreateResource(ResourceType type, int quantity);
    }
}
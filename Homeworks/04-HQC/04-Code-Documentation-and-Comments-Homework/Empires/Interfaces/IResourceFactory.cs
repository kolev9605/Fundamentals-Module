namespace Empires.Interfaces
{
    using Enums;

    /// <summary>
    /// Creates a object of IResource Type
    /// </summary>
    public interface IResourceFactory
    {
        IResource CreateResource(ResourceType type, int quantity);
    }
}
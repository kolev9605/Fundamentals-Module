namespace Empires.Interfaces
{
    using Enums;

    /// <summary>
    /// Describes a resource which has Type and Quantity
    /// </summary>
    public interface IResource
    {
        ResourceType ResourceType { get; }

        int Quantity { get; }
    }
}
namespace Empires.Interfaces
{
    /// <summary>
    /// Indicates that the building can produce resources
    /// </summary>
    public interface IResourceProducable
    {
        bool CanProduceResource { get; }
        IResource ProduceResource();
    }
}

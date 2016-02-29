namespace Empires.Interfaces
{
    public interface IResourceProducable
    {
        bool CanProduceResource { get; }
        IResource ProduceResource();
    }
}

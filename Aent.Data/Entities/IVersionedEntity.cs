namespace Aent.Data.Entities
{
    // all Domain Models are virtual to allow lazy loading
    public interface IVersionedEntity
    {
        byte[] Version { get; set; }
    }
}

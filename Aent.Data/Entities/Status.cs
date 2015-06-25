namespace Aent.Data.Entities
{
    // all Domain Models are virtual to allow lazy loading
    public class Status : IVersionedEntity
    {
        public virtual long StatusId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Ordinal { get; set; }
        public virtual byte[] Version { get; set; }
    }
}

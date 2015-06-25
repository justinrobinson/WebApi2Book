using System;

namespace Aent.Data.Entities
{
    // all Domain Models are virtual to allow lazy loading
    public class User : IVersionedEntity
    {
        public virtual long UserId { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Username { get; set; }
        public virtual byte[] Version { get; set; }
    }
}

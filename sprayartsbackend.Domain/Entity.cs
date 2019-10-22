using System;

namespace sprayartsbackend.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }
    }
}

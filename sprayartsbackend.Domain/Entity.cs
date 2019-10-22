using System;

namespace sprayartsbackend.Domain
{
    public class Entity
    {
        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }
    }
}

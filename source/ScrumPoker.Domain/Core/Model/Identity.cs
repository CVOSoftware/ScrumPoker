using System;

namespace ScrumPoker.Domain.Core.Model
{
    public abstract class Identity
    {
        protected Identity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}

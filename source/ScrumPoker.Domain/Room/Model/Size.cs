using System;

using ScrumPoker.Domain.Core.Model;

namespace ScrumPoker.Domain.Room.Model
{
    public class Size : Identity
    {
        public Size(Guid id, uint count) : base(id)
        {
            Count = count;
        }

        public uint Count { get; set; }
    }
}
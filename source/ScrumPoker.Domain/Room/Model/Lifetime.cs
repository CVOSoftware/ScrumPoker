using System;

using ScrumPoker.Domain.Core.Model;

namespace ScrumPoker.Domain.Room.Model
{
    public class Lifetime : Identity
    {
        public Lifetime(Guid id, TimeSpan time) : base(id)
        {
            Time = time;
        }

        public TimeSpan Time { get; set; }
    }
}
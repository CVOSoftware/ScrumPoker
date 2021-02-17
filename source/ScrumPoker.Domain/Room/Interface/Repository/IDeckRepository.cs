using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScrumPoker.Domain.Core.Interfaces.Repository;
using ScrumPoker.Domain.Poker.Model;

namespace ScrumPoker.Domain.Room.Interface.Repository
{
    public interface IDeckRepository : IRepository<Deck>
    {

    }
}

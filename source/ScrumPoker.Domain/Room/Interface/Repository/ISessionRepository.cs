using System;
using System.Threading.Tasks;

using ScrumPoker.Domain.Core.Interfaces.Repository;
using ScrumPoker.Domain.Room.Model;

namespace ScrumPoker.Domain.Room.Interface.Repository
{
    public interface ISessionRepository : IRepository<Session>
    {
        Task<Session> Add(Session model);

        Task Delete(Guid id);
    }
}

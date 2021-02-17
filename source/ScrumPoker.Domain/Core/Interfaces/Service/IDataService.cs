using ScrumPoker.Domain.Room.Interface.Repository;

namespace ScrumPoker.Domain.Core.Interfaces.Service
{
    public interface IDataService
    {
        IDeckRepository DeckRepository { get; }

        ILifetimeRepository LifetimeRepository { get; }

        ISessionRepository SessionRepository { get; }

        IShirtRepository ShirtRepository { get; }

        ISizeRepository SizeRepository { get; }
    }
}

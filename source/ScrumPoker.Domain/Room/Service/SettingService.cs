using System.Threading.Tasks;

using ScrumPoker.Domain.Core.Interfaces.Service;
using ScrumPoker.Domain.Core.Model;
using ScrumPoker.Domain.Room.Interface.Service;
using ScrumPoker.Domain.Room.Model;
using ScrumPoker.Domain.Room.Model.Request;

namespace ScrumPoker.Domain.Room.Service
{
    public class SettingService : ISettingService
    {
        private readonly IDataService _dataService;

        public SettingService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<Result<Setting>> Create(SettingInfo model)
        {
            var valid = model.Validate();

            if(valid == false)
            {
                return Result<Setting>.False(ISettingService.ThrowSettingValidationError);
            }

            var deck = await _dataService.DeckRepository.Get(model.DeckId);
            var shirt = await _dataService.ShirtRepository.Get(model.ShirtId);
            var lifetime = await _dataService.LifetimeRepository.Get(model.LifetimeId);
            var size = await _dataService.SizeRepository.Get(model.SizeId);

            if (deck == null || shirt == null || lifetime == null || size == null)
            {
                return Result<Setting>.False(ISettingService.ThrowSettingCreationError);
            }

            var info = new Setting
            {
                Deck = deck,
                Shirt = shirt,
                Lifetime = lifetime,
                Size = size,
                Privacy = model.Privacy
            };
            var result = Result<Setting>.True(info);

            return result;
        }
    }
}

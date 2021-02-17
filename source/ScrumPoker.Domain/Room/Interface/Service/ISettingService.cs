using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScrumPoker.Domain.Core.Model;
using ScrumPoker.Domain.Room.Model;
using ScrumPoker.Domain.Room.Model.Request;

namespace ScrumPoker.Domain.Room.Interface.Service
{
    public interface ISettingService
    {
        static Guid ThrowSettingValidationError = Guid.Parse("bca2330a-9521-4fbf-b0ba-243e4cf0e557");

        static Guid ThrowSettingCreationError = Guid.Parse("8769f2e4-b0db-4349-a10d-7ed882ac3c25");

        Task<Result<Setting>> Create(SettingInfo model);
    }
}

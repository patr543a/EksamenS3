using Entities.Contexts;
using Entities.Dto.Sosu;
using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Services;

public class ResidentService
    : ServiceBase<SosuUnitOfWork, SosuContext>, IResidentService
{
    public IEnumerable<ResidentDto> GetAllResidents()
    {
        throw new NotImplementedException();
    }
}

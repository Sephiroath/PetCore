using Core.Domain.Location;
using DataAccess.Repositories.Contracts.Location;
using DataAccess.Repositories._base;

namespace DataAccess.Repositories.Mocks.Location
{
    public class MockParkRepository : BaseRepository<Park,Park>, IParkRepository
    {
        
    }
}
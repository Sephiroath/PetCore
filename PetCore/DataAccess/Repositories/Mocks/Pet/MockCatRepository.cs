using Core.Domain.Pet;
using DataAccess.Repositories.Contracts.Pet;
using DataAccess.Repositories._base;

namespace DataAccess.Repositories.Mocks.Pet
{
    public class MockCatRepository : BaseRepository<Cat, Cat>, ICatRepository
    {
        
    }
}
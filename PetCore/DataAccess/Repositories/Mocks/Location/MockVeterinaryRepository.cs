using Core.Domain.Location;
using DataAccess.Repositories._base;
using DataAccess.Repositories.Contracts.Location;

namespace DataAccess.Repositories.Mocks.Location
{
    public class MockVeterinaryRepository : BaseRepository<Veterinary, Veterinary>, IVeterinaryRepository
    {
        
    }
}
using Core.Domain.People;
using DataAccess.Repositories.Contracts.People;
using DataAccess.Repositories._base;

namespace DataAccess.Repositories.Mocks.People
{
    public class MockModeratorRepository : BaseRepository<Moderator, Moderator>, IModeratorRepository
    {
        
    }
}
using NZWalks.API.Model.Domain;

namespace NZWalks.API.Repositories
{
    public interface IWalkRepository
    {
        Task<Walks> CreateAsync(Walks walks);
        Task<List<Walks>>GetAllAsync();
    }
}

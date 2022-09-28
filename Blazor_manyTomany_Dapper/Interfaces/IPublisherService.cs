using Blazor_manyTomany_Dapper.Entitites;

namespace Blazor_manyTomany_Dapper.Interfaces
{
    public interface IPublisherService
    {
        Task<int> Create(Publisher publisher);
        Task<Publisher> ReadByPk(int Id);
        Task<int> Update(Publisher publisher);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<List<Publisher>> FetchAll();
        Task<List<Publisher>> ListAll(int skip,
                                      int take,
                                      string orderBy,
                                      string direction,
                                      string search);
    }
}

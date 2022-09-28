using Blazor_manyTomany_Dapper.Entitites;

namespace Blazor_manyTomany_Dapper.Interfaces
{
    public interface IBookAuthorService
    {
        Task<int> Create(BookAuthorName bookAuthorNamer);
        Task<int> Delete(long isbn, int authorId);
        Task<List<BookAuthorName>> FetchAll(long isbn);
    }
}

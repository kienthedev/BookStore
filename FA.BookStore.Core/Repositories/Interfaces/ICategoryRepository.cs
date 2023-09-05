using FA.BookStore.Core.Models;

namespace FA.BookStore.Core.Interfaces
{
    /// <summary>
    /// Provides data access methods for managing book categories in the book store.
    /// </summary>
    public interface ICategoryRepository : IGenericRepository<Category>
    {
    }
}
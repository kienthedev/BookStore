using FA.BookStore.Core.Models;

namespace FA.BookStore.Core.Interfaces
{
    /// <summary>
    /// Provides data access methods for managing publishers in the book store.
    /// </summary>
    public interface IPublisherRepository : IGenericRepository<Publisher>
    {
    }
}
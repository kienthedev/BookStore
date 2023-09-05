using FA.BookStore.Core.Interfaces;
using FA.BookStore.Core.Models;

namespace FA.BookStore.Core.Repositories.Implementation
{
    /// <summary>
    /// Provides data access methods for managing publishers in the book store.
    /// </summary>
    public class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublisherRepository"/> class.
        /// </summary>
        /// <param name="context">The database context for the book store.</param>
        public PublisherRepository(BookStoreContext context) : base(context)
        {
        }
    }
}
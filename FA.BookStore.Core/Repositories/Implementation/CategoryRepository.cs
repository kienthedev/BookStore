using FA.BookStore.Core.Interfaces;
using FA.BookStore.Core.Models;

namespace FA.BookStore.Core.Repositories.Implementation
{
    /// <summary>
    /// Provides data access methods for managing book categories in the book store.
    /// </summary>
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRepository"/> class.
        /// </summary>
        /// <param name="context">The database context for the book store.</param>
        public CategoryRepository(BookStoreContext context) : base(context)
        {
        }
    }
}

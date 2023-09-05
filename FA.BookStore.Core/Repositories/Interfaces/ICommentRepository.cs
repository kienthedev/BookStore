using FA.BookStore.Core.Interfaces;
using FA.BookStore.Core.Models;

namespace FA.BookStore.Core.Repositories.Interfaces
{
    /// <summary>
    /// Provides data access methods for managing comments related to books in the book store.
    /// </summary>
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        /// <summary>
        /// Retrieves a list of comments associated with a specific book.
        /// </summary>
        /// <param name="bookId">The unique identifier of the book.</param>
        /// <returns>A list of comments related to the specified book.</returns>
        IList<Comment> GetCommentByBook(string bookId);
    }
}
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.Interfaces;

namespace FA.BookStore.Core.Repositories.Implementation
{
    /// <summary>
    /// Provides data access methods for managing comments related to books in the book store.
    /// </summary>
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentRepository"/> class.
        /// </summary>
        /// <param name="context">The database context for the book store.</param>
        public CommentRepository(BookStoreContext context) : base(context)
        {
        }

        /// <summary>
        /// Retrieves a list of comments associated with a specific book.
        /// </summary>
        /// <param name="bookId">The unique identifier of the book.</param>
        /// <returns>A list of comments related to the specified book.</returns>
        public IList<Comment> GetCommentByBook(string bookId)
        {
            return _context.Comments.Where(c => c.BookId == Convert.ToInt32(bookId)).ToList();
        }
    }
}

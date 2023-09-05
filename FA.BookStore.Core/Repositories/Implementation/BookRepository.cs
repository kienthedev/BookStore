using FA.BookStore.Core.Interfaces;
using FA.BookStore.Core.Models;

namespace FA.BookStore.Core.Repositories.Implementation
{
    /// <summary>
    /// Provides data access methods for managing books in the book store.
    /// </summary>
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookRepository"/> class.
        /// </summary>
        /// <param name="context">The database context for the book store.</param>
        public BookRepository(BookStoreContext context) : base(context)
        {
        }

        /// <summary>
        /// Counts the number of books in a specific category.
        /// </summary>
        /// <param name="category">The name of the category.</param>
        /// <returns>The count of books in the specified category.</returns>
        public int CountBooksForCategory(string category)
        {
            return _context.Books.Count(b => b.Category.CategoryName == category);
        }

        /// <summary>
        /// Counts the number of books published by a specific publisher.
        /// </summary>
        /// <param name="publisher">The name of the publisher.</param>
        /// <returns>The count of books published by the specified publisher.</returns>
        public int CountBooksForPublisher(string publisher)
        {
            return _context.Books.Count(b => b.Publisher.Name == publisher);
        }

        /// <summary>
        /// Finds a book with a summary containing the specified text.
        /// </summary>
        /// <param name="summary">The text to search for in the book summaries.</param>
        /// <returns>The first book with a matching summary, or null if none is found.</returns>
        public Book? FindBookBySummary(string summary)
        {
            return _context.Books.FirstOrDefault(b => b.Summary.ToLower().Contains(summary.ToLower()));
        }

        /// <summary>
        /// Finds a book with a specific title.
        /// </summary>
        /// <param name="title">The title of the book to find.</param>
        /// <returns>The first book with the specified title, or null if none is found.</returns>
        public Book? FindBookByTitle(string title)
        {
            return _context.Books.FirstOrDefault(b => b.Title == title);
        }

        /// <summary>
        /// Retrieves a list of books in a specific category.
        /// </summary>
        /// <param name="category">The name of the category.</param>
        /// <returns>A list of books belonging to the specified category.</returns>
        public IList<Book> GetBooksByCategory(string category)
        {
            return _context.Books.Where(b => b.Category.CategoryName == category).ToList();
        }

        /// <summary>
        /// Retrieves a list of books created in a specific month and year.
        /// </summary>
        /// <param name="monthYear">The date representing the month and year to filter by.</param>
        /// <returns>A list of books created in the specified month and year.</returns>
        public IList<Book> GetBooksByMonth(DateTime monthYear)
        {
            return _context.Books.Where(b => b.CreatedDate.Year == monthYear.Year && b.CreatedDate.Month == monthYear.Month).ToList();
        }

        /// <summary>
        /// Retrieves a list of books published by a specific publisher.
        /// </summary>
        /// <param name="publisher">The name of the publisher.</param>
        /// <returns>A list of books published by the specified publisher.</returns>
        public IList<Book> GetBooksByPublisher(string publisher)
        {
            return _context.Books.Where(b => b.Publisher.Name == publisher).ToList();
        }

        /// <summary>
        /// Retrieves a list of the latest books up to a specified size.
        /// </summary>
        /// <param name="size">The maximum number of latest books to retrieve.</param>
        /// <returns>A list of the latest books, up to the specified size.</returns>
        public IList<Book> GetLastestBook(int size)
        {
            if (size > 0)
            {
                return _context.Books.OrderByDescending(b => b.CreatedDate).Take(size).ToList();
            }
            else
            {
                return new List<Book>();
            }
        }
    }
}

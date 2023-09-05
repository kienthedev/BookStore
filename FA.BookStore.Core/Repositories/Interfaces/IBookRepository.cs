using FA.BookStore.Core.Models;

namespace FA.BookStore.Core.Interfaces
{
    /// <summary>
    /// Provides data access methods for managing books in the book store.
    /// </summary>
    public interface IBookRepository : IGenericRepository<Book>
    {
        /// <summary>
        /// Finds a book by its title.
        /// </summary>
        /// <param name="title">The title of the book to find.</param>
        /// <returns>The found book or null if not found.</returns>
        Book? FindBookByTitle(string title);

        /// <summary>
        /// Finds a book by a summary containing specified text.
        /// </summary>
        /// <param name="summary">The text to search for in the book summaries.</param>
        /// <returns>The found book or null if not found.</returns>
        Book? FindBookBySummary(string summary);

        /// <summary>
        /// Retrieves a list of the latest books up to a specified size.
        /// </summary>
        /// <param name="size">The maximum number of latest books to retrieve.</param>
        /// <returns>A list of the latest books, up to the specified size.</returns>
        IList<Book> GetLastestBook(int size);

        /// <summary>
        /// Retrieves a list of books created in a specific month and year.
        /// </summary>
        /// <param name="monthYear">The date representing the month and year to filter by.</param>
        /// <returns>A list of books created in the specified month and year.</returns>
        IList<Book> GetBooksByMonth(DateTime monthYear);

        /// <summary>
        /// Counts the number of books in a specific category.
        /// </summary>
        /// <param name="category">The name of the category.</param>
        /// <returns>The count of books in the specified category.</returns>
        int CountBooksForCategory(string category);

        /// <summary>
        /// Retrieves a list of books in a specific category.
        /// </summary>
        /// <param name="category">The name of the category.</param>
        /// <returns>A list of books belonging to the specified category.</returns>
        IList<Book> GetBooksByCategory(string category);

        /// <summary>
        /// Counts the number of books published by a specific publisher.
        /// </summary>
        /// <param name="publisher">The name of the publisher.</param>
        /// <returns>The count of books published by the specified publisher.</returns>
        int CountBooksForPublisher(string publisher);

        /// <summary>
        /// Retrieves a list of books published by a specific publisher.
        /// </summary>
        /// <param name="publisher">The name of the publisher.</param>
        /// <returns>A list of books published by the specified publisher.</returns>
        IList<Book> GetBooksByPublisher(string publisher);
    }
}

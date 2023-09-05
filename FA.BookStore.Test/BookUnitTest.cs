using FA.BookStore.Core.Interfaces;
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.Implementation;

namespace FA.BookStore.Test
{
    public class BookUnitTest
    {
        private BookStoreContext _context;
        private IBookRepository _bookRepository;

        [SetUp]
        public void Setup()
        {
            // Initialize the context and repository for each test
            _context = new BookStoreContext();
            _bookRepository = new BookRepository(_context);
        }

        [TestCase(1, "The Great Gatsby", 12.99)]
        [TestCase(2, "To Kill a Mockingbird", 14.99)]
        [TestCase(5, "Educated", 18.99)]
        [TestCase(-1, null, 0)]
        public void Find_Should_ReturnEntityById(int id, string expectedTitle, decimal expectedPrice)
        {
            var foundBook = _bookRepository.Find(id);
            if(foundBook != null)
            {
                Assert.NotNull(foundBook);
                Assert.AreEqual(expectedTitle, foundBook.Title);
                Assert.AreEqual(expectedPrice, foundBook.Price);
            } else
            {
                Assert.IsNull(foundBook);
            }
        }

        [Test]
        public void GetAll_Should_ReturnAllEntities()
        {
            var allBooks = _bookRepository.GetAll();
            Assert.AreEqual(14, allBooks.Count());
        }

        [Test]
        public void CountBooksForCategory_WhenCategoryDoesNotExist_ShouldReturnZero()
        {
            string nonExistentCategory = "NonExistentCategory";
            int bookCount = _bookRepository.CountBooksForCategory(nonExistentCategory);
            Assert.AreEqual(0, bookCount);
        }

        [TestCase("Fiction", 5)]
        [TestCase("Science Fiction", 5)]
        [TestCase("History", 1)]
        [TestCase("Self-Help", 1)]
        public void CountBooksForCategory_ShouldReturnNumber(string category, int expectedCount)
        {
            int bookCount = _bookRepository.CountBooksForCategory(category);
            Assert.AreEqual(expectedCount, bookCount);
        }

        [TestCase("Penguin Random House", 3)]
        [TestCase("HarperCollins", 3)]
        [TestCase("Hay House", 2)]
        public void CountBooksForPublisher_WhenPublisherExists_ShouldReturnCorrectCount(string publisher, int expectedCount)
        {
            int bookCount = _bookRepository.CountBooksForPublisher(publisher);
            Assert.AreEqual(expectedCount, bookCount);
        }

        [Test]
        public void CountBooksForPublisher_WhenPublisherDoesNotExist_ShouldReturnZero()
        {
            string nonExistentPublisher = "NonExistent Publisher";
            int bookCount = _bookRepository.CountBooksForPublisher(nonExistentPublisher);
            Assert.AreEqual(0, bookCount);
        }

        [Test]
        public void CountBooksForPublisher_WhenPublisherIsEmpty_ShouldReturnZero()
        {
            string emptyPublisher = "";
            int bookCount = _bookRepository.CountBooksForPublisher(emptyPublisher);
            Assert.AreEqual(0, bookCount);
        }

        [Test]
        public void CountBooksForPublisher_WhenPublisherIsNull_ShouldReturnZero()
        {
            string nullPublisher = null;
            int bookCount = _bookRepository.CountBooksForPublisher(nullPublisher);
            Assert.AreEqual(0, bookCount);
        }

        [TestCase("classic")]
        [TestCase("romantic")]
        public void FindBookBySummary_WhenSummaryExists_ShouldReturnMatchingBook(string summary)
        {
            Book? foundBook = _bookRepository.FindBookBySummary(summary);
            Assert.IsNotNull(foundBook);
            Assert.IsTrue(foundBook.Summary.ToLower().Contains(summary.ToLower()));
        }

        [Test]
        public void FindBookBySummary_WhenSummaryDoesNotExist_ShouldReturnNull()
        {
            string nonExistentSummary = "Non-existent summary";
            Book? foundBook = _bookRepository.FindBookBySummary(nonExistentSummary);
            Assert.IsNull(foundBook);
        }

        [TestCase("The Great Gatsby")]
        [TestCase("1984")]
        [TestCase("Educated")]
        public void FindBookByTitle_WhenTitleExists_ShouldReturnMatchingBook(string title)
        {
            Book? foundBook = _bookRepository.FindBookByTitle(title);
            Assert.IsNotNull(foundBook);
            Assert.AreEqual(title, foundBook.Title);
        }

        [Test]
        public void FindBookByTitle_WhenTitleDoesNotExist_ShouldReturnNull()
        {
            string nonExistentTitle = "Non-existent Title";
            Book? foundBook = _bookRepository.FindBookByTitle(nonExistentTitle);
            Assert.IsNull(foundBook);
        }

        [TestCase("Fiction", 5)]
        [TestCase("Mystery", 2)]
        public void GetBooksByCategory_WhenCategoryExists_ShouldReturnMatchingBooks(string category, int expectedCount)
        {
            IList<Book> books = _bookRepository.GetBooksByCategory(category);
            Assert.AreEqual(books.Count(), expectedCount);
        }

        [Test]
        public void GetBooksByCategory_WhenCategoryDoesNotExist_ShouldReturnEmptyList()
        {
            string nonExistentCategory = "NonExistentCategory";
            IList<Book> books = _bookRepository.GetBooksByCategory(nonExistentCategory);
            Assert.IsEmpty(books);
        }

        [Test]
        public void GetBooksByMonth_WhenBooksExistForMonth_ShouldReturnMatchingBooks()
        {
            DateTime existingDate = new DateTime(2023, 9, 1);
            IList<Book> books = _bookRepository.GetBooksByMonth(existingDate);
            Assert.IsTrue(books.All(b => b.CreatedDate.Year == existingDate.Year && b.CreatedDate.Month == existingDate.Month));
        }

        [Test]
        public void GetBooksByMonth_WhenNoBooksExistForMonth_ShouldReturnEmptyList()
        {
            DateTime nonExistentDate = new DateTime(2022, 5, 1);
            IList<Book> books = _bookRepository.GetBooksByMonth(nonExistentDate);
            Assert.IsEmpty(books);
        }

        [Test]
        public void GetBooksByMonth_WhenDateIsInTheFuture_ShouldReturnEmptyList()
        {
            DateTime futureDate = DateTime.Now.AddMonths(1);
            IList<Book> books = _bookRepository.GetBooksByMonth(futureDate);
            Assert.IsEmpty(books);
        }

        [Test]
        public void GetBooksByMonth_WhenDateIsBeforeAnyBooksWereCreated_ShouldReturnEmptyList()
        {
            DateTime dateBeforeAnyBooks = new DateTime(2020, 1, 1);
            IList<Book> books = _bookRepository.GetBooksByMonth(dateBeforeAnyBooks);
            Assert.IsEmpty(books);
        }

        [TestCase("Penguin Random House", 3)]
        [TestCase("Simon & Schuster", 3)]
        public void GetBooksByPublisher_WhenPublisherExists_ShouldReturnMatchingBooks(string publisher, int expectedCount)
        {
            IList<Book> books = _bookRepository.GetBooksByPublisher(publisher);
            Assert.AreEqual(books.Count(), expectedCount);
        }

        [Test]
        public void GetBooksByPublisher_WhenNoBooksExistForPublisher_ShouldReturnEmptyList()
        {
            string nonExistentPublisher = "NonExistent Publisher";
            IList<Book> books = _bookRepository.GetBooksByPublisher(nonExistentPublisher);
            Assert.IsEmpty(books);
        }

        [Test]
        public void GetBooksByPublisher_WhenPublisherIsEmpty_ShouldReturnEmptyList()
        {
            string emptyPublisher = "";
            IList<Book> books = _bookRepository.GetBooksByPublisher(emptyPublisher);
            Assert.IsEmpty(books);
        }

        [Test]
        public void GetBooksByPublisher_WhenPublisherIsNull_ShouldReturnEmptyList()
        {
            string nullPublisher = null;
            IList<Book> books = _bookRepository.GetBooksByPublisher(nullPublisher);
            Assert.IsEmpty(books);
        }

        [Test]
        public void GetLastestBook_WhenSizeIsGreaterThanAvailableBooks_ShouldReturnAllBooks()
        {
            int sizeGreaterThanAvailableBooks = 100;
            IList<Book> books = _bookRepository.GetLastestBook(sizeGreaterThanAvailableBooks);
            Assert.IsNotNull(books);
            Assert.AreEqual(_context.Books.Count(), books.Count);
        }

        [Test]
        public void GetLastestBook_WhenSizeIsZero_ShouldReturnEmptyList()
        {
            int sizeZero = 0;
            IList<Book> books = _bookRepository.GetLastestBook(sizeZero);
            Assert.IsEmpty(books);
        }

        [Test]
        public void GetLastestBook_WhenSizeIsNegative_ShouldReturnEmptyList()
        {
            int sizeNegative = -5;
            IList<Book> books = _bookRepository.GetLastestBook(sizeNegative);
            Assert.IsEmpty(books);
        }

        [Test]
        public void GetLastestBook_WhenSizeIsLessThanAvailableBooks_ShouldReturnLimitedBooks()
        {
            int sizeLessThanAvailableBooks = 5;
            IList<Book> books = _bookRepository.GetLastestBook(sizeLessThanAvailableBooks);
            Assert.IsNotNull(books);
            Assert.AreEqual(sizeLessThanAvailableBooks, books.Count);
        }
    }
}

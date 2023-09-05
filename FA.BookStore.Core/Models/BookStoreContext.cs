using Microsoft.EntityFrameworkCore;

namespace FA.BookStore.Core.Models
{
    /// <summary>
    /// Represents the database context for the book store application.
    /// </summary>
    public class BookStoreContext : DbContext
    {
        private string connectionStrings = "server=(local);database=BookStore;uid=sa;pwd=123456;TrustServerCertificate=True";

        /// <summary>
        /// Initializes a new instance of the <see cref="BookStoreContext"/> class.
        /// </summary>
        public BookStoreContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BookStoreContext"/> class.
        /// </summary>
        /// <param name="options">The options for configuring the context.</param>
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the collection of book categories in the database.
        /// </summary>
        public virtual DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the collection of books in the database.
        /// </summary>
        public virtual DbSet<Book> Books { get; set; }

        /// <summary>
        /// Gets or sets the collection of publishers in the database.
        /// </summary>
        public virtual DbSet<Publisher> Publishers { get; set; }

        /// <summary>
        /// Gets or sets the collection of comments in the database.
        /// </summary>
        public virtual DbSet<Comment> Comments { get; set; }

        /// <summary>
        /// Configures the database connection using the specified connection string.
        /// </summary>
        /// <param name="optionsBuilder">The options builder for configuring the database.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connectionStrings);
        }

        /// <summary>
        /// Configures the model of the database.
        /// </summary>
        /// <param name="modelBuilder">The model builder to configure the database model.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data seeding for categories
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Fiction",
                    Description = "Books of imaginative  narration"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Science Fiction",
                    Description = "Books with futuristic or speculative themes"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Mystery",
                    Description = "Books involving puzzles and suspense"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "History",
                    Description = "Books about past events and civilizations"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Self-Help",
                    Description = "Books for personal growth and development"
                });

            // Data seeding for publishers
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher
                {
                    PublisherId = 1,
                    Name = "Penguin Random House",
                    Description = "One of the world's largest English-language trade book publishers."
                },
                new Publisher
                {
                    PublisherId = 2,
                    Name = "HarperCollins",
                    Description = "A prominent publishing company with a wide range of titles."
                },
                new Publisher
                {
                    PublisherId = 3,
                    Name = "Simon & Schuster",
                    Description = "A major American book publishing company."
                },
                new Publisher
                {
                    PublisherId = 4,
                    Name = "O'Reilly Media",
                    Description = "Known for publishing books on technology and programming."
                },
                new Publisher
                {
                    PublisherId = 5,
                    Name = "Hay House",
                    Description = "Publishes self-help, spiritual, and personal growth books."
                });

            // Data seeding for books
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "The Great Gatsby",
                    CategoryId = 1,
                    AuthorId = 1,
                    PublisherId = 1,
                    Summary = "A  classic novel depicting the excesses of the Jazz Age.",
                    ImgUrl = "gatsby.jpg",
                    Price = 12.99m,
                    Quantity = 20,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 2,
                    Title = "To Kill a Mockingbird",
                    CategoryId = 1,
                    AuthorId = 2,
                    PublisherId = 2,
                    Summary = "A story addressing issues of racial injustice and moral growth.",
                    ImgUrl = "mockingbird.jpg",
                    Price = 14.99m,
                    Quantity = 15,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 3,
                    Title = "1984",
                    CategoryId = 2,
                    AuthorId = 3,
                    PublisherId = 3,
                    Summary = "A dystopian novel  exploring themes of totalitarianism and surveillance.",
                    ImgUrl = "1984.jpg",
                    Price = 10.99m,
                    Quantity = 25,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 4,
                    Title = "The Alchemist",
                    CategoryId = 3,
                    AuthorId = 4,
                    PublisherId = 4,
                    Summary = "A philosophical novel about a shepherd's journey to find his personal legend.",
                    ImgUrl = "alchemist.jpg",
                    Price = 9.99m,
                    Quantity = 30,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 5,
                    Title = "Educated",
                    CategoryId = 4,
                    AuthorId = 5,
                    PublisherId = 5,
                    Summary = "A memoir   recounting the author's journey from a survivalist family to education.",
                    ImgUrl = "educated.jpg",
                    Price = 18.99m,
                    Quantity = 10,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 6,
                    Title = "The Lord of the Rings",
                    CategoryId = 2,
                    AuthorId = 6,
                    PublisherId = 1,
                    Summary = "Epic fantasy series set in the fictional world of Middle-earth.",
                    ImgUrl = "lotr.jpg",
                    Price = 29.99m,
                    Quantity = 18,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 7,
                    Title = "Pride and Prejudice",
                    CategoryId = 1,
                    AuthorId = 7,
                    PublisherId = 2,
                    Summary = "Classic romantic novel exploring social issues and manners.",
                    ImgUrl = "pride.jpg",
                    Price = 11.99m,
                    Quantity = 22,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 8,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    CategoryId = 2,
                    AuthorId = 8,
                    PublisherId = 3,
                    Summary = "Start of the fantasy series following the journey of a young wizard.",
                    ImgUrl = "harry.jpg",
                    Price = 16.99m,
                    Quantity = 28,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 9,
                    Title = "The Catcher in the Rye",
                    CategoryId = 1,
                    AuthorId = 9,
                    PublisherId = 4,
                    Summary = "Coming-of-age novel reflecting on teenage angst and alienation.",
                    ImgUrl = "catcher.jpg",
                    Price = 13.99m,
                    Quantity = 17,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 10,
                    Title = "Lean In",
                    CategoryId = 5,
                    AuthorId = 10,
                    PublisherId = 5,
                    Summary = "A book encouraging women to pursue leadership roles and careers.",
                    ImgUrl = "leanin.jpg",
                    Price = 21.99m,
                    Quantity = 12,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 11,
                    Title = "The Hunger Games",
                    CategoryId = 2,
                    AuthorId = 11,
                    PublisherId = 1,
                    Summary = "Dystopian novel about a young girl's fight for survival in a deadly competition.",
                    ImgUrl = "hunger.jpg",
                    Price = 14.99m,
                    Quantity = 20,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 12,
                    Title = "The Martian",
                    CategoryId = 3,
                    AuthorId = 12,
                    PublisherId = 2,
                    Summary = "Science fiction novel about an astronaut stranded on Mars.",
                    ImgUrl = "martian.jpg",
                    Price = 17.99m,
                    Quantity = 15,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 13,
                    Title = "Gone Girl",
                    CategoryId = 1,
                    AuthorId = 13,
                    PublisherId = 3,
                    Summary = "Psychological thriller about a woman's mysterious disappearance.",
                    ImgUrl = "gone.jpg",
                    Price = 13.99m,
                    Quantity = 18,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                },
                new Book
                {
                    BookId = 14,
                    Title = "The Da Vinci Code",
                    CategoryId = 2,
                    AuthorId = 14,
                    PublisherId = 4,
                    Summary = "Mystery thriller involving a murder and a secret society.",
                    ImgUrl = "davinci.jpg",
                    Price = 15.99m,
                    Quantity = 25,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true
                });

            // Data seeding for comments
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId = 1,
                    BookId = 1,
                    Content = "This book is a masterpiece! I couldn't put it down.",
                    CreatedDate = DateTime.Now.AddDays(-10),
                    IsActive = true
                },
                new Comment
                {
                    CommentId = 2,
                    BookId = 1,
                    Content = "I loved the characters and the plot twists. Highly recommended.",
                    CreatedDate = DateTime.Now.AddDays(-9),
                    IsActive = true
                },
                new Comment
                {
                    CommentId = 3,
                    BookId = 2,
                    Content = "A thought-provoking read. It really makes you reflect on life.",
                    CreatedDate = DateTime.Now.AddDays(-8),
                    IsActive = true
                },
                new Comment
                {
                    CommentId = 4,
                    BookId = 2,
                    Content = "The author's writing style is beautiful. I'm a fan!",
                    CreatedDate = DateTime.Now.AddDays(-7),
                    IsActive = true
                },
                new Comment
                {
                    CommentId = 5,
                    BookId = 3,
                    Content = "I couldn't stop reading until the very end. Amazing!",
                    CreatedDate = DateTime.Now.AddDays(-6),
                    IsActive = true
                },
                new Comment
                {
                    CommentId = 6,
                    BookId = 3,
                    Content = "This book taught me so much about history. Engaging storytelling.",
                    CreatedDate = DateTime.Now.AddDays(-5),
                    IsActive = true
                },
                new Comment
                {
                    CommentId = 7,
                    BookId = 4,
                    Content = "The suspense in this book is incredible. Kept me on the edge of my seat.",
                    CreatedDate = DateTime.Now.AddDays(-4),
                    IsActive = true
                },
                new Comment
                {
                    CommentId = 8,
                    BookId = 4,
                    Content = "I'm recommending this book to all my friends. It's a must-read.",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    IsActive = true
                },
                new Comment
                {
                    CommentId = 9,
                    BookId = 5,
                    Content = "This book changed my perspective on life. Profound and touching.",
                    CreatedDate = DateTime.Now.AddDays(-2),
                    IsActive = true
                },
                new Comment
                {
                    CommentId = 10,
                    BookId = 5,
                    Content = "I shed tears while reading this. Beautifully written and emotionally powerful.",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    IsActive = true
                });
        }
    }
}

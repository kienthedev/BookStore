namespace FA.BookStore.Core.Models
{
    using System;

    /// <summary>
    /// Represents a book in the book store's inventory.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the unique identifier for the book.
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ID of the category to which the book belongs.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to access the book's category.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Gets or sets the ID of the author of the book.
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the publisher of the book.
        /// </summary>
        public int PublisherId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to access the book's publisher.
        /// </summary>
        public Publisher Publisher { get; set; }

        /// <summary>
        /// Gets or sets the summary or description of the book.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the URL of the book's cover image.
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// Gets or sets the price of the book.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the book in stock.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the date when the book record was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date when the book record was last modified.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the book is currently active.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
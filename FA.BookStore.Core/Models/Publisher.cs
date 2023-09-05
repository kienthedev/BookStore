namespace FA.BookStore.Core.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a publisher of books in the book store's inventory.
    /// </summary>
    public class Publisher
    {
        /// <summary>
        /// Gets or sets the unique identifier for the publisher.
        /// </summary>
        public int PublisherId { get; set; }

        /// <summary>
        /// Gets or sets the name of the publisher.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the publisher.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the collection of books published by this publisher.
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}
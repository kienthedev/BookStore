namespace FA.BookStore.Core.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents a category for books in the book store's inventory.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique identifier for the category.
        /// </summary>
        [Key]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the description of the category.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the collection of books belonging to this category.
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}
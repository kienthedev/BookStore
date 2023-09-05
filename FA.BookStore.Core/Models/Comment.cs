namespace FA.BookStore.Core.Models
{
    using System;

    /// <summary>
    /// Represents a comment associated with a book in the book store.
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Gets or sets the unique identifier for the comment.
        /// </summary>
        public int CommentId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the book that this comment is associated with.
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to access the book that this comment is associated with.
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the content of the comment.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the date when the comment was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the comment is currently active.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
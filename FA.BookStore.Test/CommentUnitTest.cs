using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.Implementation;
using FA.BookStore.Core.Repositories.Interfaces;
using System.ComponentModel.Design;
using System.Net;

namespace FA.BookStore.Test
{
    public class CommentUnitTest
    {
        private BookStoreContext _context;
        private ICommentRepository _commentRepository;

        [SetUp]
        public void Setup()
        {
            _context = new BookStoreContext();
            _commentRepository = new CommentRepository(_context);
        }

        [Test]
        public void AddComment_AddsCommentToDatabase()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                var comment = new Comment
                {
                    CommentId = 50,
                    BookId = 1,
                    Content = "This is a test comment.",
                    IsActive = true,
                };
                _commentRepository.Add(comment);

                var result = _commentRepository.Find(50);
                Assert.NotNull(result);
                Assert.That("This is a test comment.", Is.EqualTo(result.Content));

                transaction.Rollback();
            }
        }
    }
}

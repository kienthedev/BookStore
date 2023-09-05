using FA.BookStore.Core.Interfaces;
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.Implementation;
using FA.BookStore.Core.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Test
{
    public class PublisherUnitTest
    {
        private BookStoreContext _context;
        private IPublisherRepository _publisherRepository;

        [SetUp]
        public void Setup()
        {
            _context = new BookStoreContext();
            _publisherRepository = new PublisherRepository(_context);
        }
        [Test]
        public void AddPublisher_AddsPublisherToDatabase()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                var publisher = new Publisher
                {
                    PublisherId = 50,
                    Name = "test",
                    Description = "test",
                };
                _publisherRepository.Add(publisher);

                var result = _publisherRepository.Find(50);
                Assert.NotNull(result);
                Assert.That("test", Is.EqualTo(result.Description));

                transaction.Rollback();
            }
        }
    }
}

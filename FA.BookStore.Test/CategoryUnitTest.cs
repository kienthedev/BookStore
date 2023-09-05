using FA.BookStore.Core.Interfaces;
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.Implementation;
using System.Linq.Expressions;

namespace FA.BookStore.Test
{
    public class CategoryUnitTest
    {
        private BookStoreContext _context;
        private ICategoryRepository _categoryRepository;

        [SetUp]
        public void Setup()
        {
            // Initialize the context and repository for each test
            _context = new BookStoreContext();
            _categoryRepository = new CategoryRepository(_context);
        }

        [Test]
        public void GetAll_WithFilter_ReturnsFilteredEntities()
        {
            Expression<Func<Category, bool>> filter = c => c.CategoryName.Contains("e");
            var result = _categoryRepository.GetAll(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.IsTrue(result.All(e => e.CategoryName.Contains("e")));
        }

        [Test]
        public void Insert_NewCategory_AddCategoryToRepository_AndDeleteAfterThat()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                var category = new Category
                {
                    CategoryName = "test",
                    Description = "test",
                };
                _categoryRepository.Add(category);
                _categoryRepository.Save();

                var result = _categoryRepository.Find(category.CategoryId);
                Assert.NotNull(result);
                Assert.That(category.CategoryId, Is.EqualTo(result.CategoryId));

                transaction.Rollback();
            }
        }

        [Test]
        public void Update_ExistingCategory_UpdatesCategoryInRepository()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                var updatedCategoryName = "Updated name";
                var categoryToUpdate = _categoryRepository.Find(1);

                if (categoryToUpdate != null)
                {
                    categoryToUpdate.CategoryName = updatedCategoryName;
                    _categoryRepository.Update(categoryToUpdate);
                    _categoryRepository.Save();
                }

                var updatedCategory = _categoryRepository.Find(1);
                Assert.NotNull(updatedCategory);
                Assert.That(updatedCategoryName, Is.EqualTo(updatedCategory.CategoryName));
                transaction.Rollback();
            }
        }
    }
}

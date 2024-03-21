using TranDuyKhoa_Tuan2.Models;

namespace TranDuyKhoa_Tuan2.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoriesList;
        public MockCategoryRepository() {
            _categoriesList = new List<Category>
            {
                new Category { Id = 1,Name="Laptop"},
                new Category { Id = 2, Name = "Desktop" },
                new Category { Id = 3,Name = "Phone"}
            };
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoriesList;
        }
    }
}

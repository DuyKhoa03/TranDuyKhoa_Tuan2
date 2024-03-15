using TranDuyKhoa_Tuan2.Models;

namespace TranDuyKhoa_Tuan2.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}

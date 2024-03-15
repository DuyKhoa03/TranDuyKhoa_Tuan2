using System.Collections.Generic;
using TranDuyKhoa_Tuan2.Models;
namespace TranDuyKhoa_Tuan2.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product GetById(int id);
    void Add(Product product);  
    void Update(Product product);
    void Delete(int id);
}

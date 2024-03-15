using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TranDuyKhoa_Tuan2.Models
{
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }
        [Required,StringLength(100)]
        [DisplayName("Tên sản phẩm")]

        public string Name { get; set; }
        [Range(0.01,10000.00)]
        [DisplayName("Giá")]

        public decimal Price { get; set; }
        [DisplayName("Mô tả")]

        public string Description { get; set; }
        [DisplayName("Mã loại sản phẩm")]

        public int CategoryId { get; set; }
    }
}

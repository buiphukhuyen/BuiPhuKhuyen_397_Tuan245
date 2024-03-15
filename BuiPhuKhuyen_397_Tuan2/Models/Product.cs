using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BuiPhuKhuyen_397_Tuan2.Models
{
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }

        [Range(0.01, 10000.00)]
        [DisplayName("Giá bán")]
        public decimal Price { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [DisplayName("Mã loại")]
        public int CategoryId { get; set; }

    }
}

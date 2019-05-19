
using System.ComponentModel.DataAnnotations.Schema;

namespace MariaDbWithNetCore.Model.Entity
{
    [Table(nameof(ProductImage))]
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string Url { get; set; }
        public short Order { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
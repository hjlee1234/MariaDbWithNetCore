
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MariaDbWithNetCore.Entity
{
    [Table(nameof(Product))]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public string Summery { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public short UnitSize { get; set; }
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductInStore> ProductInStores { get; set; }

    }
}

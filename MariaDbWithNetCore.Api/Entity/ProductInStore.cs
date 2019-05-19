using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MariaDbWithNetCore.Entity
{
    [Table(nameof(ProductInStore))]
    public class ProductInStore
    {
        [Key]
        public int ProductId { get; set; }
        [Key]
        public int StoreId { get; set; }
        public bool HasShortage { get; set; }
        public DateTime ShortageDateTime { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
    }
}

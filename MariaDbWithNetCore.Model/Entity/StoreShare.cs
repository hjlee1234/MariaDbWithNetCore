using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MariaDbWithNetCore.Model.Entity
{
    [Table(nameof(StoreShare))]
    public class StoreShare
    {
        [Key]
        public int StoreId { get; set; }

        [Key]
        public int GroupId { get; set; }

        [Range(0, 99)]
        public short SharePercent { get; set; }

        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}

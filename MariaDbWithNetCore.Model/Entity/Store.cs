
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MariaDbWithNetCore.Model.Entity
{
    [Table(nameof(Store))]
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public string Grade { get; set; }
        public short StartTime { get; set; }
        public short EndTime { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Responsible { get; set; }
        public string IBAN { get; set; }

        public ICollection<ProductInStore> ProductInStores { get; set; }
        public ICollection<StoreShare> StoreShares { get; set; }
    }
}

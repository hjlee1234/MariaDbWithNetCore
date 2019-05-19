using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MariaDbWithNetCore.Entity
{
    [Table(nameof(Group))]
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NerdShopping.API.Models.Base;

namespace NerdShopping.API.Models
{
    [Table("tab_product")]
    public class Product : BaseEntity
    {
        [Column("des_name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("vl_price")]
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }

        [Column("des_description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("des_category")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("image_ url")]
        [StringLength(300)]
        public string ImageUrl { get; set; }
    }
}
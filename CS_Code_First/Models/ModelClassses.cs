using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS_Code_First.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryUniqueId { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryId { get; set; }
        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }
        public decimal BasePrice { get; set; }
        // One-to-Many Relationship
        // The Product MUST Refer the CategoryUniqueId in it
        public ICollection<Product> Products { get; set; }
    }
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductUniqueId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(300)]
        public string Manufacturer { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Vat { get; set; }
        public decimal TotalPrice { get; set; }
        // reference Key
        [Required]
        public int CategoryUniqueId { get; set; }
        // Establish One-to-One Relationship and the CategoryUnuiqueId
        public Category Category { get; set; }
    }
}

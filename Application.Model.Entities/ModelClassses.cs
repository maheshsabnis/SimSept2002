using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Model.Entity.Base;
namespace Application.Model.Entities
{
    [Table("Category")]
    public class Category : EntityBase
    {
        [Key]
        public int CategoryUniqueId { get; set; }
        [Required(ErrorMessage ="Category Id is required")]
        [StringLength(50)]
        public string CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
        [StringLength(200)]
        public string CategoryName { get; set; }
        public decimal BasePrice { get; set; }
        // One-to-Many Relationship
        // The Product MUST Refer the CategoryUniqueId in it
        public ICollection<Product> Products { get; set; }
    }
    [Table("Product")]
    public class Product : EntityBase
    {
        [Key]
        public int ProductUniqueId { get; set; }
        [Required(ErrorMessage = "Product Id is required")]
        [StringLength(50)]
        public string ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(200)]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Manufacturer is required")]
        [StringLength(300)]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(500)]
        public string Description { get; set; }
        [NumericNonNegative(ErrorMessage = "Price MUST be Positive Numeric")]
        public decimal Price { get; set; }
        public decimal Vat { get; set; }
        public decimal TotalPrice { get; set; }
        // reference Key
        [Required(ErrorMessage = "Category Id is required")]
        public int CategoryUniqueId { get; set; }
        // Establish One-to-One Relationship and the CategoryUnuiqueId
        public Category Category { get; set; }
    }
}

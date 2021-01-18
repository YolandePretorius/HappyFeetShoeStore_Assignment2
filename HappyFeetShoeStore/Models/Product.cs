using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HappyFeetShoeStore.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The product name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "Please enter a product name between 3 made up of letters and numbers only")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The product description cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product description between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "Please enter a product description between 3 made up of letters and numbers only")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The price cannot be blank")]
        [Range(0.1,10000,ErrorMessage = "Please enter a price between 0.1 and 10000.00")]
        [RegularExpression("[0-9]+(\\.[0-9][0-9]?)?", ErrorMessage = "The price must be a number up to two decimal places")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }


        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductImageMapping> ProductImageMappings { get; set; }
    }
}
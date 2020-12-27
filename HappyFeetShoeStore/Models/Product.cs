using System.ComponentModel.DataAnnotations;

namespace HappyFeetShoeStore.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
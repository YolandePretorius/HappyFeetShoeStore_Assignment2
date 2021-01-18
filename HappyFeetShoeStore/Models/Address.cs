using System.ComponentModel.DataAnnotations;

namespace HappyFeetShoeStore.Models
{
    public class Address
    {
        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Required]
        public string Town { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string County { get; set; } //spelling error needs to be country
        [Required]
        public string Postcode { get; set; }
    }
}
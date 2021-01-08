using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace HappyFeetShoeStore.Models
{
    public class ProductImage
    {
        public int ID { get; set; }
        [Display(Name = "File")]
        [StringLength(100)]
        [Index(IsUnique=true)] // make sure files uploaded is unique
        public string FileName { get; set; }
        //public IEnumerable<ProductImageMapping> ProductImageMappings { get; internal set; }
        public virtual ICollection<ProductImageMapping> ProductImageMappings { get; set; }
    }
}
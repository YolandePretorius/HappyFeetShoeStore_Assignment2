using HappyFeetShoeStore.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HappyFeetShoeStore.ViewModel
{
    public class BasketViewModel
    {
        public List<BasketLine> BasketLines { get; set; }
        [Display(Name = "Basket Total:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal TotalCost { get; set; }
    }
}
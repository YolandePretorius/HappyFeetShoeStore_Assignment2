﻿using HappyFeetShoeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyFeetShoeStore.ViewModel
{
    public class BestSellersViewModel
    {
        public Product Product { get; set; }
        public int SalesCount { get; set; }
        public string ProductImage { get; set; }
    }
}
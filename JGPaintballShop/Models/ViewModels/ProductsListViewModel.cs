﻿using System.Collections.Generic;
using JGPaintballShop.Models;

namespace JGPaintballShop.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}

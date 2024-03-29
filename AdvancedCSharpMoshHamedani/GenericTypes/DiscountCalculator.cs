﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCSharp.Library;

namespace GenericTypes
{
    public class DiscountCalculator<TProduct> where TProduct: Product
    {
        public decimal CalculateDiscount(TProduct product)
        {
            return product.Price * 0.5M;
        }
    }
}

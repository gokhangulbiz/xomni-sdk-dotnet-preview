﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOMNI.SDK.Public.Models.Catalog
{
    public class Price
    {
        public double NormalPrice { get; set; }
        public double? DiscountPrice { get; set; }
        public string PriceTypeSymbol { get; set; }
        public int PriceTypeId { get; set; }
    }
}

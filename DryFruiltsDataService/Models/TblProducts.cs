﻿using System;
using System.Collections.Generic;

namespace DryFruiltsDataService.Models
{
    public partial class TblProducts
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? Modified { get; set; }
        public string ProductTypeText { get; set; }
    }
}

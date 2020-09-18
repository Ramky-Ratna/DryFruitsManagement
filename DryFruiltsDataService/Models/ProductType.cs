using System;
using System.Collections.Generic;

namespace DryFruiltsDataService.Models
{
    public partial class ProductType
    {
        public int TypeId { get; set; }
        public string ProductTypeText { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? Modified { get; set; }
    }
}

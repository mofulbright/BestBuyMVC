using System;
using System.Collections.Generic;

namespace BestBuyMVC.bestbuy
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int? ProductId { get; set; }
        public string? Reviewer { get; set; }
        public int? Rating { get; set; }
        public string? Comment { get; set; }

        public virtual Product? Product { get; set; }
    }
}

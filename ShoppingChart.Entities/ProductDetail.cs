using System;
using System.Collections.Generic;

namespace ShoppingChart.Entities
{
    public partial class ProductDetail
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ModelNumber { get; set; }
        public string Pictures { get; set; }
        public string Price { get; set; }

        public virtual Products Product { get; set; }
    }
}

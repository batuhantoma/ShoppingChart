using System;
using System.Collections.Generic;

namespace ShoppingChart.Entities
{
    public partial class Products
    {
        public Products()
        {
            ProductDetail = new HashSet<ProductDetail>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<ProductDetail> ProductDetail { get; set; }
    }
}

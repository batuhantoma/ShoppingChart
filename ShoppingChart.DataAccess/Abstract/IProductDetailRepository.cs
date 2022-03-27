using ShoppingChart.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingChart.DataAccess.Abstract
{
    public interface IProductDetailRepository
    {
        List<ProductDetail> GetAllProductDetail();
        ProductDetail GetProductDetailById(int Id);
        ProductDetail CreateProductDetail(ProductDetail products);
        ProductDetail UpdateProductDetail(ProductDetail products);
        void DeleteProductDetail(int Id);
    }
}

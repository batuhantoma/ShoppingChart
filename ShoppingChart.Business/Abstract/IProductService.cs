using ShoppingChart.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingChart.Business.Abstract
{
    public interface IProductService
    {
        List<Products> GetAllProduct();
        Products GetProductById(int Id);
        Products CreateProducts(Products products);
        Products UpdateProducts(Products products);
        void DeleteProducts(int Id);
    }
}

using ShoppingChart.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingChart.DataAccess.Abstract
{
    public interface IProductRepository
    {
        List<Products> GetAllProduct();
        Products GetProductById(int Id);
        Products CreateProducts(Products products);
        Products UpdateProducts(Products products);
        void DeleteProducts(int Id);
    }
}

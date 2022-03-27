using ShoppingChart.Business.Abstract;
using ShoppingChart.DataAccess.Abstract;
using ShoppingChart.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingChart.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepositroy;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepositroy = productRepository;
        }

        public Products CreateProducts(Products products)
        {
            return _productRepositroy.CreateProducts(products);
        }

        public void DeleteProducts(int Id)
        {
            _productRepositroy.DeleteProducts(Id);
        }

        public List<Products> GetAllProduct()
        {
            return _productRepositroy.GetAllProduct();
        }

        public Products GetProductById(int Id)
        {
            return _productRepositroy.GetProductById(Id);
        }

        public Products UpdateProducts(Products products)
        {
            return _productRepositroy.UpdateProducts(products);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using ShoppingChart.DataAccess.Abstract;
using ShoppingChart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingChart.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoppingChartContext _context;
        public ProductRepository(ShoppingChartContext context)
        {
            _context = context;
        }

        public Products CreateProducts(Products products)
        {
            _context.Products.Add(products);
            _context.SaveChanges();
            return products;
        }

        public void DeleteProducts(int Id)
        {
            var checkProduct = _context.Products.Where(p => p.Id == Id);

            if (checkProduct.Any())
            {
                throw new Exception("This product has a relation. Firstly, remove a related data");
            }

            var getProductById = GetProductById(Id);
            _context.Products.Remove(getProductById);
            _context.SaveChanges();
        }

        public List<Products> GetAllProduct()
        {
            return _context.Products.Include(i => i.ProductDetail).ToList();
        }

        public Products GetProductById(int Id)
        {
            return _context.Products.Include(i => i.ProductDetail).FirstOrDefault(p => p.Id == Id);
        }

        public Products UpdateProducts(Products products)
        {
            _context.Products.Update(products);
            _context.SaveChanges();
            return products;
        }
    }
}

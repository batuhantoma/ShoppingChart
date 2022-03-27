using Microsoft.EntityFrameworkCore;
using ShoppingChart.DataAccess.Abstract;
using ShoppingChart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingChart.DataAccess.Concrete
{
    public class ProductDetailRepository : IProductDetailRepository
    {
        private readonly ShoppingChartContext _context;
        public ProductDetailRepository(ShoppingChartContext context)
        {
            _context = context;
        }

        public ProductDetail CreateProductDetail(ProductDetail productDetail)
        {
            _context.ProductDetail.Add(productDetail);
            _context.SaveChanges();
            return productDetail;
        }

        public void DeleteProductDetail(int Id)
        {
            var getProductDetailById = GetProductDetailById(Id);
            _context.ProductDetail.Remove(getProductDetailById);
            _context.SaveChanges();
        }

        public List<ProductDetail> GetAllProductDetail()
        {
            return _context.ProductDetail.Include(i => i.Product).ToList();
        }

        public ProductDetail GetProductDetailById(int Id)
        {
            return _context.ProductDetail.Include(i => i.Product).FirstOrDefault(p => p.Id == Id);
        }

        public ProductDetail UpdateProductDetail(ProductDetail productDetail)
        {
            _context.ProductDetail.Update(productDetail);
            _context.SaveChanges();
            return productDetail;
        }
    }
}

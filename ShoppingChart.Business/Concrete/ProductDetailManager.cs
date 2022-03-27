using ShoppingChart.Business.Abstract;
using ShoppingChart.DataAccess.Abstract;
using ShoppingChart.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingChart.Business.Concrete
{
    public class ProductDetailManager : IProductDetailService
    {
        private IProductDetailRepository _productDetailRepository;
        public ProductDetailManager(IProductDetailRepository productDetailRepository)
        {
            _productDetailRepository = productDetailRepository;
        }

        public ProductDetail CreateProductDetail(ProductDetail products)
        {
            return _productDetailRepository.CreateProductDetail(products);
        }

        public void DeleteProductDetail(int Id)
        {
            _productDetailRepository.DeleteProductDetail(Id);
        }

        public List<ProductDetail> GetAllProductDetail()
        {
            return _productDetailRepository.GetAllProductDetail();
        }

        public ProductDetail GetProductDetailById(int Id)
        {
            return _productDetailRepository.GetProductDetailById(Id);
        }

        public ProductDetail UpdateProductDetail(ProductDetail products)
        {
            return _productDetailRepository.UpdateProductDetail(products);
        }
    }
}

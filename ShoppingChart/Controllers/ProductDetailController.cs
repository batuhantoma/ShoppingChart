using Microsoft.AspNetCore.Mvc;
using ShoppingChart.Business.Abstract;
using ShoppingChart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingChart.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly ShoppingChartContext _context;
        private IProductDetailService _productDetailService;

        public ProductDetailController(ShoppingChartContext context, IProductDetailService productDetailService)
        {
            _context = context;
            _productDetailService = productDetailService;
        }
        public IActionResult Index()
        {
            var response = _productDetailService.GetAllProductDetail();
            return View(response);
        }

        [HttpPost]
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewProduct(ProductDetail productDetail)
        {
            _productDetailService.CreateProductDetail(productDetail);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            _productDetailService.DeleteProductDetail(Id);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateProduct(int Id)
        {
            var productDetail = _context.ProductDetail.Find(Id);
            _productDetailService.UpdateProductDetail(productDetail);
            return View("UpdateProduct");
        }

        public ActionResult Update(ProductDetail productDetail)
        {
            _productDetailService.UpdateProductDetail(productDetail);
            return RedirectToAction("Index");
        }
    }
}

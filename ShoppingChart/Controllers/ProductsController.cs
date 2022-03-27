using Microsoft.AspNetCore.Mvc;
using ShoppingChart.Business.Abstract;
using ShoppingChart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingChart.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShoppingChartContext _context;
        private IProductService _productService;

        public ProductsController(ShoppingChartContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;
        }
        public IActionResult Index()
        {
            var response = _productService.GetAllProduct();
            return View(response);
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewProduct(Products products)
        {
            _productService.CreateProducts(products);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            _productService.DeleteProducts(Id);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateProduct(int Id)
        {
            var product = _context.Products.Find(Id);
            _productService.UpdateProducts(product);
            return View("UpdateProduct", product);
        }

        public ActionResult Update(Products products)
        {
            _productService.UpdateProducts(products);
            return RedirectToAction("Index");
        }
    }
}

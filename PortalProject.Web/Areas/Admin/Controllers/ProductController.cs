using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Products;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService, IUnitOfWork uow)
            : base(uow)
        {
            _productService = productService;
        }

        // GET: Admin/Product
        public ActionResult ListProduct()
        {
            ProductModel _productModel = new ProductModel();
            _productModel.ProductList = _productService.GetAll().ToList();

            return View(_productModel);
        }
    }
}
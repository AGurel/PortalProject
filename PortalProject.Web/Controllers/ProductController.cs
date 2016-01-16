﻿using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Pages;
using PortalProject.Service.Products;
using PortalProject.Service.Settings;
using PortalProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Controllers
{
     public class ProductController : BaseController 
    {
        private readonly IProductService _productService;

        public ProductController(ISettingService settingService, IContactService contactService, IPageService pageService, IProductService productService, IUnitOfWork uow)
            : base(settingService, contactService, pageService, uow)
        {
            _productService = productService;
        }

        // GET: Page
        public ActionResult ProductDetail(int productId)
        {
            ProductModel _productModel = new ProductModel();
            _productModel.Product = _productService.Find(productId);

            return View(_productModel);
        }
    }
}
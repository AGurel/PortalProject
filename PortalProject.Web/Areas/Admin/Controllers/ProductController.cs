using PortalProject.Core.Domain.Entity;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Products;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            Product product = _productService.Find(id);

            ProductModel _productModel = new ProductModel
            {
                Id = product.Id,
                Active = product.Active,
                Content = product.Content,
                Name = product.Name,
                Order = product.Order,
            };

            return View(_productModel);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProductAdd(ProductModel model, HttpPostedFileBase Photo)
        {
            if (Photo != null)
            {
                var fileName = Path.GetFileNameWithoutExtension(Photo.FileName);
                var extension = Path.GetExtension(Photo.FileName);
                var fileFullName = Guid.NewGuid() + fileName.Replace(" ", "").Replace(".", "") + extension;
                var path = Path.Combine(Server.MapPath("~/Content/images/urun"), fileFullName);
                Photo.SaveAs(path);

                Product product = new Product
                {
                    Active = model.Active,
                    Content = model.Content,
                    Photo = "images/urun/" + fileFullName,
                    Name = model.Name,
                    Order = model.Order
                };

                _productService.Insert(product);
                _uow.SaveChanges();
            }

            return RedirectToAction("ListProduct");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProductEdit(ProductModel model, HttpPostedFileBase Photo)
        {
            int id = int.Parse(Request.Form["hfId"]);
            Product product = _productService.Find(id);

            if (Photo != null)
            {
                var fileName = Path.GetFileNameWithoutExtension(Photo.FileName);
                var extension = Path.GetExtension(Photo.FileName);
                var fileFullName = Guid.NewGuid() + fileName.Replace(" ", "").Replace(".", "") + extension;
                var path = Path.Combine(Server.MapPath("~/Content/urun/haber"), fileFullName);
                Photo.SaveAs(path);
                product.Photo = "images/urun/" + fileFullName;
            }

            product.Active = model.Active;
            product.Content = model.Content;
            product.Order = model.Order;
            product.Name = model.Name;

            _productService.Update(product);
            _uow.SaveChanges();

            return RedirectToAction("ListProduct");
        }

        [HttpPost]
        public ActionResult ProductDelete(int productId)
        {
            _productService.Delete(productId);
            _uow.SaveChanges();

            return RedirectToAction("ListProduct");
        }
    }
}
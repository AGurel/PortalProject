using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalProject.Service.Products
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IUnitOfWork uow)
        {
            _uow = uow;
            _productRepository = uow.GetRepository<Product>();
        }

        /// <summary>
        /// Get all products.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Product> GetAll()
        {
            return _productRepository.GetAll().OrderBy(x => x.Order);
        }
        
        /// <summary>
        /// Find product by product id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Find(int productId)
        {
            return _productRepository.Find(productId);
        }

        /// <summary>
        /// Insert new product.
        /// </summary>
        /// <param name="product"></param>
        public void Insert(Product product)
        {
            _productRepository.Insert(product);
        }

        /// <summary>
        /// Update a product.
        /// </summary>
        /// <param name="product"></param>
        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        /// <summary>
        /// Delete a product by product entity.
        /// </summary>
        /// <param name="product">Product</param>
        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        /// <summary>
        /// Delete a product by product id.
        /// </summary>
        /// <param name="productId">Product Id</param>
        public void Delete(int productId)
        {
            _productRepository.Delete(productId);
        }
    }
}

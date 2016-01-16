using PortalProject.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalProject.Service.Products
{
    public interface IProductService
    {
        /// <summary>
        /// Get all products.
        /// </summary>
        /// <returns></returns>
        IQueryable<Product> GetAll();

        /// <summary>
        /// Find product by id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Product Find(int productId);

        /// <summary>
        /// Insert a new product.
        /// </summary>
        /// <param name="product"></param>
        void Insert(Product product);

        /// <summary>
        /// Update a product.
        /// </summary>
        /// <param name="setting"></param>
        void Update(Product setting);

        /// <summary>
        /// Delete a product by product.
        /// </summary>
        /// <param name="product">Product</param>
        void Delete(Product product);

        /// <summary>
        /// Delete a product by product id.
        /// </summary>
        /// <param name="productId"></param>
        void Delete(int productId);
    }
}

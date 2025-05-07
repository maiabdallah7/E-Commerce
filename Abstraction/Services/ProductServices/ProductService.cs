using Application.Contracts;
using E_commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepositry;

        public ProductService(IProductRepository productRepositry)
        {
            _productRepositry = productRepositry;
        }

        public Product AddProduct(Product product)
        {
            var p = _productRepositry.Create(product);
            _productRepositry.SaveChanges();
            return p;
        }
        public Product UpdateProduct(Product product)
        {
            return _productRepositry.Update(product);
        }

        public Product DeleteProduct(Product product)
        {
            return (_productRepositry.Delete(product));
        }
        public List<Product> GetAll() 
        { 
            return _productRepositry.GetAll().ToList(); 
        }

        public Product GetProductById(int id)
        {
            return _productRepositry.GetById(id);
        }

    }
}

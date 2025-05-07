using E_commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ProductServices
{
    public interface IProductService
    {
        public Product AddProduct(Product product);

        public Product UpdateProduct(Product product);

        public Product DeleteProduct(Product product);

        public List<Product> GetAll();

        public Product GetProductById(int id);
    }
}

using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public interface IProductRepository
        {
            IEnumerable<Product> GetAllProducts();
            Product GetProduct(int id);
        }
    
}


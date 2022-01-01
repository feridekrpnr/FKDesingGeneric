using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetAllProducts(); //tüm ürünleri getir
        Task<Product> GetProductById(int id); //idsi ? olan ürünü getir
        Task<Product> CreateProduct(Product product); //entity
        Task UpdateProduct(Product productToBeUpdate, Product product);
        Task DeleteProduct(Product product);
    }
}

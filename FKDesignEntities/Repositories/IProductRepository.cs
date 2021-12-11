using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignEntities.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {

        Task<Product> GetWithCategoryByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllWithCategoryAsync();
    }
}

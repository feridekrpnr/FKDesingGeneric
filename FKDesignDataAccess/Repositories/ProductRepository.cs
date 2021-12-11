using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignDataAccess.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(FKDesignDBContext context) : base(context) { }

        private FKDesignDBContext FKDesignDBContext
        {
            get { return Context as FKDesignDBContext; }
        }
        public async Task<IEnumerable<Product>> GetAllWithCategoryAsync()
        {
            return await FKDesignDBContext.Products.ToListAsync();
        }

        public async Task<Product> GetWithCategoryByIdAsync(int id)
        {
            return await FKDesignDBContext.Products.Include(w => w.category).SingleOrDefaultAsync(w => w.ProductId == id);
        }
    }
}

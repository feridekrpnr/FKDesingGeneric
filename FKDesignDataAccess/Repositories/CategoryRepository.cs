using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignDataAccess.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(FKDesignDBContext context) : base(context) { }

        public async Task<IEnumerable<Category>>GetAllWithProductAsync()
        {
            return (IEnumerable<Category>)await FKDesignDBContext.Categories.Include(a => a.Products).SingleOrDefaultAsync();
        }
        private FKDesignDBContext FKDesignDBContext
        {
            get { return Context as FKDesignDBContext; }
        }
    }
}

using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignEntities.Repositories
{
   public interface ICategoryRepository: IRepository<Category>
    {
        Task<IEnumerable<Category>> GetAllWithProductAsync();
    }
   
}

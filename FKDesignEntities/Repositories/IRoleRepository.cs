using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignEntities.Repositories
{
    public interface IRoleRepository : IRepository<Role>
    {
        //Task<IEnumerable<Role>> GetAllWithUserAsync();

    }
}

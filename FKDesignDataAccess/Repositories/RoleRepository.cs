using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignDataAccess.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(FKDesignDBContext context) : base(context) { }

        //public async Task<IEnumerable<Role>> GetAllWithUserAsync()
        //{
        //   return (IEnumerable<Role>)await FKDesignDBContext.Role.Include(a => a.UserName).SingleOrDefaultAsync();
        //}
        private FKDesignDBContext FKDesignDBContext
        {
            get { return Context as FKDesignDBContext; }
        }
    }
}

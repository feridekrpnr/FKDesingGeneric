using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignDataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(FKDesignDBContext context) : base(context) { }
        public async Task<IEnumerable<User>> GetAllWithProfileAsync()
        {
            return (IEnumerable<User>)await FKDesignDBContext.User.Include(a => a.Profiles).SingleOrDefaultAsync();
        }
        private FKDesignDBContext FKDesignDBContext
        {
            get { return Context as FKDesignDBContext; }
        }
    }
}

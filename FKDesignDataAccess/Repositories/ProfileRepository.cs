using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FKDesignDataAccess.Repositories
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(FKDesignDBContext context) : base(context) { }
        public async Task<Profile> GetWithUserByIdAsync(int id)
        {
            return await FKDesignDBContext.Profiles.Include(w => w.User).SingleOrDefaultAsync(w => w.ProfileId == id);
        }

        public async Task<IEnumerable<Profile>> GetAllWithUserAsync()
        {
            return await FKDesignDBContext.Profiles.ToListAsync();
        }

        private FKDesignDBContext FKDesignDBContext
        {
            get { return Context as FKDesignDBContext; }
        }
    }
}
        


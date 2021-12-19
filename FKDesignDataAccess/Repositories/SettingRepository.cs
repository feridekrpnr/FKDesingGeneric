using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKDesignDataAccess.Repositories
{
    public class SettingRepository : Repository<Setting>, ISettingRepository
    {
        public SettingRepository(FKDesignDBContext context) : base(context) { }
    
    }
}

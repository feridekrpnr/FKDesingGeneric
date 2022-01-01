using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKDesignDataAccess.Repositories
{
    public class FaqRepository : Repository<Faq>, IFaqRepository
    {
        public FaqRepository(FKDesignDBContext context) : base(context) { }
    }
    
}

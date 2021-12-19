using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKDesignDataAccess.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(FKDesignDBContext context) : base(context) { }
    }
}

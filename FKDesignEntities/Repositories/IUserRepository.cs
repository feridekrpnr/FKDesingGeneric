using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignEntities.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        //tüm kullanıcıları listelemek istersem
        Task<IEnumerable<User>> GetAllWithProfileAsync();

    }
}

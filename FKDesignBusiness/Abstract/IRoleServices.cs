using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    public interface IRoleServices
    {
        Task<IEnumerable<Role>> GetAllRoles(); //tüm rolleri getir
        Task<Role> GetRoleById(int id); //idsi ? olan rolü getir
        Task<Role> CreateRole(Role role); //entity
        Task UpdateRole(Role roleToBeUpdate, Role role);
        Task DeleteRole(Role role);
    }
}

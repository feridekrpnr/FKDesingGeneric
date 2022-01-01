using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Concrete
{
    public class RoleServices : IRoleServices

    {
        private IUnitOfWork _unitOfWork;

        //alt katmana bağlanma: constructer method ile (constructer method class ismi ile aynı olmalı
        public RoleServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async Task<Role> CreateRole(Role role)
        {
            await _unitOfWork.Role.AddAsync(role);
            return role;
        }

        public Task DeleteRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetRoleById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRole(Role roleToBeUpdate, Role role)
        {
            throw new NotImplementedException();
        }
    }
}

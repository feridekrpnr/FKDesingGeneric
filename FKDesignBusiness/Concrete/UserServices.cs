
using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Concrete
{
    public class UserServices : IUserServices
    {
        private IUnitOfWork _unitOfWork;

        //alt katmana bağlanma: constructer method ile (constructer method class ismi ile aynı olmalı
        public UserServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async  Task<User> CreateUser(User user)
        {
            //data üzerinden işlem yapılacağı için await kullanılır
            await _unitOfWork.User.AddAsync(user);
            return user;
        }

        public async Task DeleteUser(User user)
        {
            _unitOfWork.User.Remove(user);
            await _unitOfWork.CommitAsync();
        }

        public async  Task<IEnumerable<User>> GetAllWithUsers()
        {
            return await _unitOfWork.User.GetAllAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _unitOfWork.User.GetByIdAsync(id);
        }

        public async Task UpdateUser(User userToBeUpdate, User user)
        {
            userToBeUpdate.UserName = user.UserName;
            userToBeUpdate.Password= user.Password;
            await _unitOfWork.CommitAsync();
        }
    }
}

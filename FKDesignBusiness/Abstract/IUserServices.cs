using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    interface IUserServices
    {
        Task<IEnumerable<User>> GetAllWithUsers();//tüm kullanıcıları getir
        Task<User> GetUserById(int id); // id si? olan kullanıları getir
        Task<User> CreateUser(User user); //entity
        Task UpdateUser(User userToBeUpdate, User user);
        Task DeleteUser(User user);
    }
}

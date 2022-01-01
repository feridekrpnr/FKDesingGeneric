using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    interface IProfileServices
    {
        Task<IEnumerable<Profile>> GetAllProfiles(); //tüm profilleri getir
        Task<Profile> GetProfileById(int id); //idsi ? olan profili getir
        Task<Profile> CreateUser(Profile profile); //entity
        Task UpdateProfile(Profile profileToBeUpdate, Profile profile);
        Task DeleteProfile(Profile profile);
    }
}
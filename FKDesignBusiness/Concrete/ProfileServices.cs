using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Concrete
{

    public class ProfileServices : IProfileServices
    {
        //bağımsız olarak tüm methodlara erişebiliriz
        private IUnitOfWork _unitOfWork;

        //alt katmana bağlanma: constructer method ile (constructer method class ismi ile aynı olmalı
        public ProfileServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public async Task<Profile> CreateUser(Profile profile)
        {
            //data üzerinden işlem yapılacağı için await kullanılır
            await _unitOfWork.Profiles.AddAsync(profile);
            return profile;
        }

        public async Task DeleteProfile(Profile profile)
        {
            _unitOfWork.Profiles.Remove(profile);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Profile>> GetAllProfiles()
        {
            return await _unitOfWork.Profiles.GetAllWithUserAsync();
        }

       
        public async Task<IEnumerable<Profile>> GetAllWithUser()
        {
            //yapılan sorgunun array list tipinde olmasını istersek IEnumerable kullanır(ramda tutulur)
            return await _unitOfWork.Profiles.GetAllWithUserAsync();
        }

        public async Task<Profile> GetProfileById(int id)
        {
            return await _unitOfWork.Profiles.GetByIdAsync(id);
        }

        public async Task UpdateProfile(Profile profileToBeUpdate, Profile profile)
        {
            profileToBeUpdate.Address = profile.Address;
            profileToBeUpdate.User_Id = profile.User_Id;
            await _unitOfWork.CommitAsync();
        }
    }
}

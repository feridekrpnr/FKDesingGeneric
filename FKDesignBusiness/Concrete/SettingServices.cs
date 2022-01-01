using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Concrete
{
    public class SettingServices : ISettingServices
    {
        private IUnitOfWork _unitOfWork;

        //alt katmana bağlanma: constructer method ile (constructer method class ismi ile aynı olmalı
        public SettingServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async Task<Setting> CreateSetting(Setting setting)
        {
            //data üzerinden işlem yapılacağı için await kullanılır
            await _unitOfWork.Settings.AddAsync(setting);
            return setting;
        }

        public async Task DeleteSetting(Setting setting)
        {
            _unitOfWork.Settings.Remove(setting);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Setting>> GetAllWithSettings()
        {
            return await _unitOfWork.Settings.GetAllAsync();
        }

        public  async Task<Setting> GetSettingById(int id)
        {
            return await _unitOfWork.Settings.GetByIdAsync(id);
        }

        public async Task UpdateSetting(Setting settingToBeUpdate, Setting setting)
        {
            settingToBeUpdate.SettingName = setting.SettingName;
            settingToBeUpdate.Title = setting.Title;
            await _unitOfWork.CommitAsync();
        }
    }
}

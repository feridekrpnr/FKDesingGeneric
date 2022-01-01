using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    public interface ISettingServices
    {
        Task<IEnumerable<Setting>> GetAllWithSettings();//tüm ayarlamaları getir
        Task<Setting> GetSettingById(int id); // id si? olan ayarlamaları getir
        Task<Setting> CreateSetting(Setting setting); //entity
        Task UpdateSetting(Setting settingToBeUpdate, Setting setting);
        Task DeleteSetting(Setting setting);
    }
}

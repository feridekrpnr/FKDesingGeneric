using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace FKDesignBusiness.Abstract
{
    public interface IImageServices
    {
        Task<IEnumerable<Image>> GetAllImages(); //tüm yorumları getir
        Task<Image> GetImageById(int id); //idsi ? olan yorumu getir
        Task<Image> CreateMessage(Image image); //entity
        Task UpdateImage(Image imageToBeUpdate, Image image);
        Task DeleteImage(Image image);
    }
}

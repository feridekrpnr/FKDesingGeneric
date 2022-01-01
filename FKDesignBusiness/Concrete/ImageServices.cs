using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Concrete
{
    public class ImageServices : IImageServices
    {
        private IUnitOfWork _unitOfWork;
        public ImageServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async  Task<Image> CreateMessage(Image image)
        {
            await _unitOfWork.Images.AddAsync(image);
            return image;
        }

        public async Task DeleteImage(Image image)
        {
            _unitOfWork.Images.Remove(image);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Image>> GetAllImages()
        {
            return await _unitOfWork.Images.GetAllAsync();
        }

        public async Task<Image> GetImageById(int id)
        {
            return await _unitOfWork.Images.GetByIdAsync(id);
        }

        public async Task UpdateImage(Image imageToBeUpdate, Image image)
        {
            imageToBeUpdate.Title = image.Title;
            await _unitOfWork.CommitAsync();
        }
    }
}

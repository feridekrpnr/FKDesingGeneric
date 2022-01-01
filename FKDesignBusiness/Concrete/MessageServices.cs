using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Concrete
{
    public class MessageServices : IMessageServices
    {
        private IUnitOfWork _unitOfWork;
        public MessageServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Message> CreateMessage(Message message)
        {
            await _unitOfWork.Messages.AddAsync(message);
            return message;
        }

        public async Task DeleteMessage(Message message)
        {
            _unitOfWork.Messages.Remove(message);
            await _unitOfWork.CommitAsync();
        }

        public async  Task<IEnumerable<Message>> GetAllMessage()
        {
            return await _unitOfWork.Messages.GetAllAsync();
        }

        public async  Task<Message> GetMessageById(int id)
        {
            return await _unitOfWork.Messages.GetByIdAsync(id);
        }

        public async Task UpdateMessage(Message messageToBeUpdate, Message message)
        {
            messageToBeUpdate.Name = message.Name;
            await _unitOfWork.CommitAsync();
        }
    }
}

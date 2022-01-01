using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    public interface IMessageServices
    {
        Task<IEnumerable<Message>> GetAllMessage(); //tüm yorumları getir
        Task<Message> GetMessageById(int id); //idsi ? olan yorumu getir
        Task<Message> CreateMessage(Message message); //entity
        Task UpdateMessage(Message messageToBeUpdate, Message message);
        Task DeleteMessage(Message message);
    }
}

using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    public interface ICommentServices
    {
        Task<IEnumerable<Comment>> GetAllComments(); //tüm yorumları getir
        Task<Comment> GetCommentById(int id); //idsi ? olan yorumu getir
        Task<Comment> CreateComment(Comment comment); //entity
        Task UpdateComment(Comment commentToBeUpdate, Comment comment);
        Task DeleteComment(Comment comment);
    }
}

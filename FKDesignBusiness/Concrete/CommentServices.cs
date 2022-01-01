using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Concrete
{
    public class CommentServices : ICommentServices
    {
        private IUnitOfWork _unitOfWork;
        public CommentServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Comment> CreateComment(Comment comment)
        {
            await _unitOfWork.Comments.AddAsync(comment);
            return comment;
        }

        public async Task DeleteComment(Comment comment)
        {
            _unitOfWork.Comments.Remove(comment);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Comment>> GetAllComments()
        {
            return await _unitOfWork.Comments.GetAllAsync();
        }

        public async Task<Comment> GetCommentById(int id)
        {
            return await _unitOfWork.Comments.GetByIdAsync(id);
        }

        public async Task UpdateComment(Comment commentToBeUpdate, Comment comment)
        {
            commentToBeUpdate.CommentName = comment.CommentName;
            await _unitOfWork.CommitAsync();
        }
    }
}

using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKDesignDataAccess.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(FKDesignDBContext context) : base(context) { }
    
    }
}

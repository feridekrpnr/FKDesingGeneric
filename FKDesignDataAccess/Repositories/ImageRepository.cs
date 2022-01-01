using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKDesignDataAccess.Repositories
{
    public class ImageRepository: Repository<Image>, IImageRepository
    {
        public ImageRepository(FKDesignDBContext context) : base(context) { }
    }
}

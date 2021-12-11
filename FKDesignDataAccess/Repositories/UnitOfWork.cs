using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignDataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private FKDesignDBContext _context;
        private ProductRepository _productRepository;
        private ProfileRepository _profileRepository;
        private UserRepository _userRepository;
        private CategoryRepository _categoryRepository;


        public UnitOfWork(FKDesignDBContext context) //constructor
        {
            this._context = context;
        }
        public IUserRepository User => _userRepository = _userRepository ?? new UserRepository(_context);

        public IProfileRepository Profiles => _profileRepository = _profileRepository ?? new ProfileRepository(_context);

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

      

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

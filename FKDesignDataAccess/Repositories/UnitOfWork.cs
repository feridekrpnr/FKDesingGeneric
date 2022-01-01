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
        private ICommentRepository _commentRepository;
        private IOrderRepository _orderRepository;
        private IRoleRepository _roleRepository;
        private ISettingRepository _settingRepository;
        private IImageRepository _imageRepository;
        private IMessageRepository _messageRepository;
        private IFaqRepository _faqRepository;



        public UnitOfWork(FKDesignDBContext context) //constructor
        {
            this._context = context;
        }
        public IUserRepository User => _userRepository = _userRepository ?? new UserRepository(_context);

        public IProfileRepository Profiles => _profileRepository = _profileRepository ?? new ProfileRepository(_context);

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository = _commentRepository ?? new CommentRepository(_context);

        public IOrderRepository Orders => _orderRepository = _orderRepository ?? new OrderRepository(_context);

        public ISettingRepository Settings => _settingRepository = _settingRepository ?? new SettingRepository(_context);

        public IRoleRepository Role => _roleRepository = _roleRepository ?? new RoleRepository(_context);
        public IImageRepository Images=> _imageRepository = _imageRepository ?? new ImageRepository(_context);
        public IMessageRepository Messages => _messageRepository = _messageRepository ?? new MessageRepository(_context);
        public IFaqRepository Faqs => _faqRepository = _faqRepository ?? new FaqRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

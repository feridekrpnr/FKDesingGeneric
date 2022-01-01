using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignEntities.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        IProfileRepository Profiles { get; }
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IOrderRepository Orders { get; }
        IRoleRepository Role { get; }
        IImageRepository Images { get; }
        IFaqRepository Faqs { get; }
        IMessageRepository Messages { get; }
        ISettingRepository Settings { get; }

        Task<int> CommitAsync();
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignEntities.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ValueTask<TEntity> GetByIdAsync(int id); //bir idye göre

        Task<IEnumerable<TEntity>> GetAllAsync();//hepsini çağırma
        //IEnumarable liste olarak çağırılmasını sağlar
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        // tek bir data dön ya single yada default (dönecek değer yoksa 0 döner)
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        //bir tane data create edilecek buyüzden liste gerek yok
        Task AddAsync(TEntity entity);

        // belli bir aralıkta değer create etmek için
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);// birden fazla silmek için



    }
}

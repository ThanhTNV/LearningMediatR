using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Domain.Entity;

namespace ECommerce_v2.Domain.Interface.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddAsync(Address address, CancellationToken cancellationToken = default);
        Task<TEntity> FindAsync(Guid addressId, CancellationToken cancellationToken = default);
        Task RemoveAsync(Guid addressId, CancellationToken cancellationToken = default);
        void Update(TEntity address);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> value);
    }
}

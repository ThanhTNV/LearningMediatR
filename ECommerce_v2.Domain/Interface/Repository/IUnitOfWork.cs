using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_v2.Domain.Interface.Repository
{
    public interface IUnitOfWork: IDisposable
    {
        public IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> BeginTransactionAsync(CancellationToken cancellation = default);
        Task<int> CommitTransactionAsync(CancellationToken cancellation = default);
        Task RollbackTransactionAsync(CancellationToken cancellation = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

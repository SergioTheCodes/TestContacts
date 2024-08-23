using Domain;
using Domain.Interfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UnitofWork : IUnitOfWork
    {
        private readonly ContactContext _contactContext;
        public UnitofWork(ContactContext contactContext)
        {
            _contactContext = contactContext;
        }
        public IAsyncRepository<T> AsyncRepository<T> () where T : BaseEntity{
            return new RepositoryBase<T>(_contactContext);
            }
        

        public Task<int> SaveChangesAsync()
    {
        return _contactContext.SaveChangesAsync();
            }
    }
}

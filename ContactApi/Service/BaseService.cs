using Domain.Interfaces;

namespace ContactApi.Service
{
    public class BaseService
    {
        public BaseService(IUnitOfWork unitOfWork)
        {
           UnitOfWork = unitOfWork;
        }
        protected internal IUnitOfWork UnitOfWork { get; set; }
        
    }
}

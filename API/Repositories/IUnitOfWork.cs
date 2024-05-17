using API.DTO;
using API.Models;

namespace API.Repositories
{
    public interface IUnitOfWork
    {
        //IGenericRepository<T, Y> GetGenericRepository<T, Y>() where T : class where Y : class;
        IGenericRepository<CustomUser> Users { get; }
        IGenericRepository<Form> Forms { get; }

        Task CompleteAsync();
    }       
}

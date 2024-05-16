using API.DTO;

namespace API.Repositories
{
    public interface IUnitOfWork
    {
        //IGenericRepository<T, Y> GetGenericRepository<T, Y>() where T : class where Y : class;
        IGenericRepository<CustomUser> Users { get; }
        //ITokenService Tokens { get; }
        Task CompleteAsync();
    }       
}

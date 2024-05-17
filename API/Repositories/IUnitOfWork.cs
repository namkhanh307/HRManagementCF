using API.DTO;
using API.Models;

namespace API.Repositories
{
    public interface IUnitOfWork
    {
        //IGenericRepository<T, Y> GetGenericRepository<T, Y>() where T : class where Y : class;
        IGenericRepository<CustomUser> Users { get; }
        IGenericRepository<FormDTO> FormDTOs { get; }
        IGenericRepository<SalaryDTO> Salaries { get; }


        Task CompleteAsync();
    }       
}

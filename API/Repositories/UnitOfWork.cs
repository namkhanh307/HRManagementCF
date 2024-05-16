using API.DTO;
using API.Models;

namespace API.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly HRMDbContext _context;

        public UnitOfWork(HRMDbContext context)
        {
            _context = context;
            Users = new GenericRepository<CustomUser>(_context);
            //Tokens = new TokenRepository(_context);
        }

        public IGenericRepository<CustomUser> Users { get; private set; }
        //public ITokenService Tokens { get; private set; }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

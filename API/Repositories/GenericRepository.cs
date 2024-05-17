using API.DTO;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HRMDbContext _context;
        private readonly DbSet<T> _dbSet;


        public GenericRepository(HRMDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();

        }

        //public async Task<CustomUser> SignUp(SignUpDTO signUpDTO)
        //{
        //    var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.UserName == signUpDTO.Username);
        //    if (existingUser != null)
        //    {
        //        throw new Exception("Username is already taken.");
        //    }

        //    var newUser = new CustomUser
        //    {
        //        Id = Convert.ToString(Guid.NewGuid()),
        //        UserName = signUpDTO.Username,
        //        // Hash the password before storing it in the database (use a password hashing library)
        //        PasswordHash = _tokenRepository.Hash(signUpDTO.Password),
        //        NormalizedUserName = signUpDTO.Name,
        //        Email = signUpDTO.Email,
        //    };

        //    _context.Users.Add(newUser);
        //    await _context.SaveChangesAsync();
        //    return newUser;
        //}
        //public async Task<string> SignIn(SignInDTO signInDTO)
        //{       
        //    var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == signInDTO.Username);
        //    if (user == null || !_tokenRepository.Verify(user.PasswordHash, signInDTO.Password))
        //    {
        //        throw new Exception("Invalid username or password.");
        //    }
        //    return _tokenRepository.GenerateJwtToken(user);
        //}
        public virtual async Task<List<T>> GetAllEntity()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetEntityByID(string id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<bool> AddEntity(T entity)
        {
            var entityType = entity.GetType();
            var keyProperty = entityType.GetProperty("Id");
            if (keyProperty == null)
            {
                throw new InvalidOperationException("Entity does not have an Id property");
            }

            var keyValue = keyProperty.GetValue(entity);
            var existingEntity = await _dbSet.FindAsync(keyValue);

            if (existingEntity == null)
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public virtual async Task<T> UpdateEntity(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> DeleteEntity(string id)
        {
            var entity = await GetEntityByID(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<CustomUser> GetEntityByName(string username)
        {
            return await _context.Set<CustomUser>()
                                 .FirstOrDefaultAsync(user => user.UserName == username);
        }
    }
}

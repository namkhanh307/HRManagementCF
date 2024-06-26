﻿using API.DTO;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;

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
            return await _context.Set<CustomUser>().FirstOrDefaultAsync(user => user.UserName == username);
        }

        public async Task<List<FormDTO>> GetUserFormsAsync(string userId, int? formTypeId)
        {
            IQueryable<Form> query = _context.Forms.Include(f => f.FormType).Include(f => f.CustomUser);

            if (!string.IsNullOrWhiteSpace(userId))
            {
                query = query.Where(f => f.UserId == userId);
            }

            if (formTypeId.HasValue)
            {
                query = query.Where(f => f.FormTypeId == formTypeId);
            }

            var forms = await query.ToListAsync();

            return forms.Select(f => new FormDTO
            {
                //Id = f.Id,
                Title = f.Title,
                Reason = f.Reason,
                Description = f.Description,
                CreatedDate = (DateTime)f.CreatedDate,
                FilePath = f.FilePath,
                FormTypeId = f.FormTypeId,
                UserId = f.UserId
            }).ToList();
        }
        public async Task<SalaryDTO?> GetSalaryByUser(string userId)
        {
            var salary = await _context.Salaries
                                       .Where(s => s.UserId == userId)
                                       .FirstOrDefaultAsync();

            if (salary == null)
            {
                return null;
            }

            return new SalaryDTO
            {
                Id = salary.Id,
                FixedAmount = salary.FixedAmount,
                UserId = salary.UserId,
                // Add other properties if needed
            };
        }

        public async Task<List<Form>> GetFormsByUserIdAndTypeAsync(string userId, int formTypeId, int month, int year)
        {
            return await _context.Forms
                .Where(f => f.UserId == userId &&
                            f.FormTypeId == formTypeId &&
                            f.CreatedDate.Year == year &&
                            f.CreatedDate.Month == month)
                .ToListAsync();
        }

        public async Task<double> CalculateMonthlySalaryRepo(string userId, int month, int year)
        {
            var salary = await GetSalaryByUser(userId);
            if (salary == null)
            {
                throw new KeyNotFoundException("Salary not found for the specified user");
            }

            var fixedAmount = salary.FixedAmount ?? 0;

            var totalDaysInMonth = DateTime.DaysInMonth(year, month);
            var leaveForms = await GetFormsByUserIdAndTypeAsync(userId, 1, month, year);
            int? numberOfLeaves = 0;
            foreach (var form in leaveForms)
            {
                numberOfLeaves += form.DayQuantity;
            }
            //var numberOfLeaves = leaveForms.Count();
            var workingDays = totalDaysInMonth - numberOfLeaves;

            var monthlySalary = fixedAmount * workingDays;
            return (double)monthlySalary;
        }
    }
}

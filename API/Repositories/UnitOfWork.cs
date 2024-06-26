﻿using API.DTO;
using API.Models;
using Microsoft.SqlServer.Server;

namespace API.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly HRMDbContext _context;

        public UnitOfWork(HRMDbContext context)
        {
            _context = context;
            Users = new GenericRepository<CustomUser>(_context);
            FormDTOs = new GenericRepository<FormDTO>(_context);
            Salaries = new GenericRepository<SalaryDTO>(_context);


        }

        public IGenericRepository<CustomUser> Users { get; private set; }

        public IGenericRepository<FormDTO> FormDTOs { get; private set; }

        public IGenericRepository<SalaryDTO> Salaries { get; private set; }


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

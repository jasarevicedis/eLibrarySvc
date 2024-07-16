using DAL.Data;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User> FindByEmail(string email)
        {
            return await _dataContext.users.Include(u => u.UserRole).FirstAsync(x => x.Email == email);
        }

        public async Task<User> FindByUsername(string username)
        {
            return await _dataContext.users.Include(u => u.UserRole).FirstAsync(x => x.Username == username);
        }

        public async Task<List<User>> GetAllByRole(string role)
        {
            return await _dataContext.users.Where(x => x.UserRole.Name == role).ToListAsync();
        }

        public async Task<User> GetUserById(int userId)
        {
            return await _dataContext.users.AsNoTracking().Include(u => u.UserRole).FirstAsync( x => x.Id == userId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Application.Interfaces.Repositories;
using TaskManagementSystem.Domain.Entities;
using TaskManagementSystem.Infrastructure.Persistence.Context;

namespace TaskManagementSystem.Infrastructure.Repositories;

public class UserRepository
    : GenericRepository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context)
        : base(context)
    {
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _context.Users
            .FirstOrDefaultAsync(x => x.Email == email);
    }

    public async Task<bool> EmailExistsAsync(string email)
    {
        return await _context.Users
            .AnyAsync(x => x.Email == email);
    }
}

using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Application.Interfaces.Repositories
{
    public interface IRefreshTokenRepository : IGenericRepository<RefreshToken>
    {
        Task<RefreshToken> GetByTokenAsync(string token);
    }
}

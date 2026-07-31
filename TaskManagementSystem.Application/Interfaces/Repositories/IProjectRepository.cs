using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Application.Interfaces.Repositories
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Task<IEnumerable<Project>> GetProjectByUserIdAsync(Guid userId);
    }
}

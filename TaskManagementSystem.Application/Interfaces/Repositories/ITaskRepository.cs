using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Application.Interfaces.Repositories
{
    public interface ITaskRepository : IGenericRepository<TaskItem>
    {
        Task<IEnumerable<TaskItem>> GetTasksByProjectIdAsync(Guid projectId);
        Task<IEnumerable<TaskItem>> GetTaskByAssignedUserIdAsync(Guid userId);
    }
}

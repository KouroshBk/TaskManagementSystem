using TaskManagementSystem.Domain.Common;
using TaskManagementSystem.Domain.Enums;

namespace TaskManagementSystem.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public Priority Priority { get; set; }
        public Enums.TaskStatus Status { get; set; }
        public DateTime DueDate { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public Guid AssignedUserId { get; set; }
        public User AssignedUser { get; set; } = null!;
    }
}

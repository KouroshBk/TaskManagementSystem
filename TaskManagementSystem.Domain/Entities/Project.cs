using TaskManagementSystem.Domain.Common;

namespace TaskManagementSystem.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid OwnerId { get; set; }
        public User Owner { get; set; } = null!;
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}

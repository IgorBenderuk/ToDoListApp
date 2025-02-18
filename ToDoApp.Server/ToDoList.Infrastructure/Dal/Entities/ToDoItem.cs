

using ToDoList.Infrastructure.Dal.Entities.Enums;

namespace ToDoList.Infrastructure.Dal.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public PriorityLevel Priority { get; set; }
        public ToDoStatus Status { get; set; }
        public int ToDoListId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public DateTime CompletedAt { get; set; }

        public ToDoListEntity ToDoList { get; set; }
    }
}
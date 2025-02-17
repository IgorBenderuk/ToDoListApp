namespace ToDoList.Infrastructure.Dal.Entities
{
    public class ToDoListEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsArchived { get; set; }

        public User User { get; set; }
        public ICollection<ToDoItem> toDoItems { get; set; }
    }
}
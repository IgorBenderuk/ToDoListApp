namespace ToDoList.Infrastructure.Dal.Entities
{
    public class ToDoItemsList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<TaskItem> TaskItems { get; set; }
        public UserEntity UserEntity { get; set; }
    }
}
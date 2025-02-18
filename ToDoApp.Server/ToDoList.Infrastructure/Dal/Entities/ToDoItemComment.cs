namespace ToDoList.Infrastructure.Dal.Entities
{
    public class ToDoItemComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int ToDoItemId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public TaskItem ItemEntity { get; set; }
    }
}
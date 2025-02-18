namespace ToDoList.Infrastructure.Dal.Entities
{
    public class ToDoTag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public ICollection<ToDoItem> ToDoItems { get; set; }
    }
}

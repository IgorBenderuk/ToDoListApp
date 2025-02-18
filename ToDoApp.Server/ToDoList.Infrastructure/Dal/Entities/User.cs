namespace ToDoList.Infrastructure.Dal.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }

        public ICollection<ToDoListEntity> ToDoLists { get; set; }
    }
}
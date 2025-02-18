using Microsoft.AspNetCore.Identity;

namespace ToDoList.Infrastructure.Dal.Entities
{
    public class UserEntity : IdentityUser<int>
    {
        public string FullName { get; set; }
        public ICollection<ToDoItemsList> ToDoLists { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using ToDoList.Infrastructure.Dal.Entities;

namespace ToDoList.Infrastructure.Dal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }
        DbSet<ToDoItem> ToDoItems { get; set; }
        DbSet<ToDoListEntity> ToDoLists { get; set; }
        DbSet<ToDoTag> ToDoTags { get; set; }
        DbSet<ToDoComment> ToDoComments { get; set; }
    }
}
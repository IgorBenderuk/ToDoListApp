using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoList.Infrastructure.Dal.Entities;

namespace ToDoList.Infrastructure.Dal
{
    public class AppDbContext : IdentityDbContext<UserEntity,IdentityRole<int>,int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<TaskItem> ToDoItems { get; set; }
        public DbSet<Entities.ToDoItemsList> ToDoLists { get; set; }
        public DbSet<ToDoItemComment> ToDoComments { get; set; }
    }
}
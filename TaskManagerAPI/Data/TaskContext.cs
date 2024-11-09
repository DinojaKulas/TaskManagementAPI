using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Model;

namespace TaskManagerAPI.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<UserLogin> userLogin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(a => a.Address)
                .WithOne(b => b.user)
                .HasForeignKey<Address>(x => x.Id);

            modelBuilder.Entity<User>()
                .HasMany(a => a.Tasks)
                .WithOne(t => t.User)
                .HasForeignKey(x => x.AssigneeId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}

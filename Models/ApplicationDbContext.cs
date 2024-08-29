using Microsoft.EntityFrameworkCore;
namespace ToDoListApp.Models
{
 public class ApplicationDbContext : DbContext
 {
 public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
 : base(options)
 {
 }
public DbSet<TodoItem> TodoItems { get; set; }
 }
}
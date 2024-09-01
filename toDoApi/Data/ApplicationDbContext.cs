using Microsoft.EntityFrameworkCore;
using toDoApi.Models.Entities;

namespace toDoApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        //{

        //}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<toDo>toDos { get; set; }
    }
}

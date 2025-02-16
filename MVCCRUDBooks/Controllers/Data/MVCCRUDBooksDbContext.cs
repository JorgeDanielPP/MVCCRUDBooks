using Microsoft.EntityFrameworkCore;
using MVCCRUDBooks.Models.Entities;



namespace MVCCRUDBooks.Controllers.Data
{
    public class MVCCRUDBooksDbContext : DbContext
    {
        public MVCCRUDBooksDbContext(DbContextOptions<MVCCRUDBooksDbContext> options) : base(options)
        { }
       public DbSet<Models.Entities.Book> Books { get; set; }


    }

}



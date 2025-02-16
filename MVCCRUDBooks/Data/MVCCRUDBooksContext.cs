using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCRUDBooks.Models.Entities;

namespace MVCCRUDBooks.Data
{
    public class MVCCRUDBooksContext : DbContext
    {
        public MVCCRUDBooksContext (DbContextOptions<MVCCRUDBooksContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCRUDBooks.Models.Entities.Book> Books { get; set; } = default!;
    }
}

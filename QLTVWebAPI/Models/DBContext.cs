using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTVWebAPI.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookCategory> BookCategories { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<MembershipCard> MembershipCards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

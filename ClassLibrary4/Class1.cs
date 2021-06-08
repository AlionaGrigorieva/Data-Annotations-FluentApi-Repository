using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ClassLibrary4
{
    public class SageBook
    {
        public int IdSage { get; set; }
        public int IdBook { get; set; }
        public virtual Sage Sage { get; set; }
        public virtual Book Book { get; set; }
    }

    public class Sage
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SageBook> SageBooks { get; set; }
        public Sage()
        {
            SageBooks = new List<SageBook>();
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SageBook> SageBooks { get; set; }
        public Book()
        {
            SageBooks = new List<SageBook>();
        }
    }
    public class SageBookContext : DbContext
    {
        public SageBookContext(string conStr) : base(conStr)
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sage>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Book>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Sage>().HasKey(x => x.Id);
            modelBuilder.Entity<Book>().HasKey(x => x.Id);
            modelBuilder.Entity<Sage>().Property(x => x.Name).HasMaxLength(20);
            modelBuilder.Entity<Book>().Property(x => x.Name).HasMaxLength(30);
            modelBuilder.Entity<SageBook>().HasKey(x => new { x.IdSage, x.IdBook });
            modelBuilder.Entity<SageBook>().HasRequired(x => x.Sage).WithMany(x => x.SageBooks).WillCascadeOnDelete(true);
            modelBuilder.Entity<SageBook>().HasRequired(x => x.Book).WithMany(x => x.SageBooks).WillCascadeOnDelete(true);
        }

        public DbSet<Sage> Sages { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}

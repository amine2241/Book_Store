using System;
using System.Collections.Generic;
using book_store.Models;
using Microsoft.EntityFrameworkCore;

namespace book_store.Data;

public partial class BookdbContext : DbContext
{
    public BookdbContext()
    {
    }

    public BookdbContext(DbContextOptions<BookdbContext> options)
        : base(options)
    {
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    => optionsBuilder.UseSqlServer("Server=GOLD\\SQLEXPRESS; Database=bookdb;Trusted_Connection=True; TrustServerCertificate=True;");
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Book>().HasData(
    //        new Book { Id = 1, Author= "Wharton, Edith", Description= "Ethan Frome works his unproductive farm and struggles to maintain a bearable existence with his difficult, suspicious and hypochondriac wife, Zeena. But when Zeena's vivacious cousin enters their hous", Name= "ETHAN FROME", Title = "" ,Genre= "Horror Fiction", Price=12,YearPublished=1998, ImageUrl = "https://jackets.dmmserver.com/media/356/97801413/9780141389400.jpg#images.titelive.com" },
    //        new Book { Id = 2, Author = "Wharton, Edith", Description = "Ethan Frome works his unproductive farm and struggles to maintain a bearable existence with his difficult, suspicious and hypochondriac wife, Zeena. But when Zeena's vivacious cousin enters their hous", Name = "ETHAN FROMEe", Title = "", Genre = "Horror Fiction", Price = 12, YearPublished = 1998, ImageUrl = "https://jackets.dmmserver.com/media/356/97801413/9780141389400.jpg#images.titelive.com" }
    //        );

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using book_store.Data;

#nullable disable

namespace book_store.Migrations
{
    [DbContext(typeof(BookdbContext))]
    [Migration("20240111160440_cart_item")]
    partial class cart_item
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("book_store.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearPublished")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Wharton, Edith",
                            Description = "Ethan Frome works his unproductive farm and struggles to maintain a bearable existence with his difficult, suspicious and hypochondriac wife, Zeena. But when Zeena's vivacious cousin enters their hous",
                            Genre = "Horror Fiction",
                            ImageUrl = "https://jackets.dmmserver.com/media/356/97801413/9780141389400.jpg#images.titelive.com",
                            Name = "ETHAN FROME",
                            Price = 12m,
                            Title = "",
                            YearPublished = 1998
                        },
                        new
                        {
                            Id = 2,
                            Author = "Wharton, Edith",
                            Description = "Ethan Frome works his unproductive farm and struggles to maintain a bearable existence with his difficult, suspicious and hypochondriac wife, Zeena. But when Zeena's vivacious cousin enters their hous",
                            Genre = "Horror Fiction",
                            ImageUrl = "https://jackets.dmmserver.com/media/356/97801413/9780141389400.jpg#images.titelive.com",
                            Name = "ETHAN FROMEe",
                            Price = 12m,
                            Title = "",
                            YearPublished = 1998
                        });
                });

            modelBuilder.Entity("book_store.Models.CartItem", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("CartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("BookId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("book_store.Models.CartItem", b =>
                {
                    b.HasOne("book_store.Models.Book", "book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");
                });
#pragma warning restore 612, 618
        }
    }
}
using Microsoft.EntityFrameworkCore;
using book_store.Models;
using book_store.Data;

namespace ShoppingCart.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(BookdbContext context)
        {
            context.Database.Migrate();

     
                Category fantasy = new Category { Name = "Fantasy" };
                Category horror = new Category { Name = "Horror"};

                context.Books.AddRange(
     new Book
     {
         Name = "The Catcher in the Rye",
         Author = "J.D. Salinger",
         Description = "A classic novel exploring the struggles of adolescence.",
         YearPublished = 1951,
         Genre = "Fiction",
         Category = fantasy,
         Price = 200,
         ImageUrl = "catcher-in-the-rye.jpg"
     },
     new Book
     {
         Name = "1984",
         Author = "George Orwell",
         Description = "A dystopian novel depicting a totalitarian society.",
         YearPublished = 1949,
         Genre = "Fiction",
         Category = horror,
         Price = 100,
         ImageUrl = "1984.jpg"
     },
     new Book
     {
         Name = "The Hobbit",
         Author = "J.R.R. Tolkien",
         Description = "A fantasy novel about the adventures of Bilbo Baggins.",
         YearPublished = 1937,
         Genre = "Fantasy",
         Category = fantasy,
         Price = 150,
         ImageUrl = "the-hobbit.jpg"
     },
     new Book
     {
         Name = "The Martian",
         Author = "Andy Weir",
         Description = "Science fiction novel about an astronaut stranded on Mars.",
         YearPublished = 2011,
         Genre = "Science Fiction",
         Category = horror,
         Price = 50,
         ImageUrl = "the-martian.jpg"
     },
     new Book
     {
         Name = "Educated",
         Author = "Tara Westover",
         Description = "Memoir about a woman who grows up in a strict and abusive household but eventually escapes to learn about the world.",
         YearPublished = 2018,
         Genre = "Memoir",
         Category = fantasy,
         Price = 30,
         ImageUrl = "educated.jpg"
     },
     new Book
     {
         Name = "The Silent Patient",
         Author = "Alex Michaelides",
         Description = "Psychological thriller about a woman's act of violence against her husband.",
         YearPublished = 2019,
         Genre = "Thriller",
         Category = horror,
         Price = 80,
         ImageUrl = "the-silent-patient.jpg"
     },
     new Book
     {
         Name = "The Power of Habit",
         Author = "Charles Duhigg",
         Description = "Exploration of the science behind why habits exist and how they can be changed.",
         YearPublished = 2012,
         Genre = "Non-Fiction",
         Category = fantasy,
         Price = 160,
         ImageUrl = "the-power-of-habit.jpg"
     },
     new Book
     {
         Name = "Becoming",
         Author = "Michelle Obama",
         Description = "Memoir of the former First Lady of the United States.",
         YearPublished = 2018,
         Genre = "Memoir",
         Category = horror,
         Price = 300,
         ImageUrl = "becoming.jpg"
     }
 );


                context.SaveChanges();
            
        }
    }
}
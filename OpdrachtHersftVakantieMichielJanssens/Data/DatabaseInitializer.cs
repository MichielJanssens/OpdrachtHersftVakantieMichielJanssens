using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpdrachtHersftVakantieMichielJanssens.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace OpdrachtHersftVakantieMichielJanssens.Data
{
    public class DatabaseInitializer
    {
        public static void InitializeDatabase(EntityContext entityContext)
        {
            entityContext.Database.EnsureCreated();

            var books = new List<Book>();

            books.Add(new Book { Author = "Author 1", CreatedOn = DateTime.Now, ISBN = "isbn 1", Title = "title 1", Genre = "horror" });
            books.Add(new Book { Author = "Author 1", CreatedOn = DateTime.Now, ISBN = "isbn 1", Title = "title 1", Genre = "horror" });
            books.Add(new Book { Author = "Author 1", CreatedOn = DateTime.Now, ISBN = "isbn 1", Title = "title 1", Genre = "horror" });
            books.Add(new Book { Author = "Author 1", CreatedOn = DateTime.Now, ISBN = "isbn 1", Title = "title 1", Genre = "horror" });

            entityContext.Books.AddRange(books);
            entityContext.SaveChanges();
        }
    }
}

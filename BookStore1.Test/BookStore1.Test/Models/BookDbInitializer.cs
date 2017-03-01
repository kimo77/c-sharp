using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore1.Test.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "War and Peace", Autor = "Leo Tolstoy", Price = 220 });
            db.Books.Add(new Book { Name = "Fathers and Sons", Autor = "Ivan Turgenev", Price = 180 });
            db.Books.Add(new Book { Name = "The Seagull", Autor = "Anton Chekhov", Price = 150 });

            base.Seed(db);
        }
    }
}
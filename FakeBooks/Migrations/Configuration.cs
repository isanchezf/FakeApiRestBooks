namespace FakeBooks.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FakeBooks.Models.BooksDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BooksDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Id = 1,
                    Titulo = "Pride and Prejudice",
                    Genero = "Comedy of manners",
                    Autor = "Jane Austen"
                },
                new Book()
                {
                    Id = 2,
                    Titulo = "Northanger Abbey",
                    Genero = "Gothic parody",
                    Autor = "Charles Dickens"
                });
        }
    }
}

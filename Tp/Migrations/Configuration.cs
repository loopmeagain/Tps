namespace Tp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Tp.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Tp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Tp.Models.ApplicationDbContext context)
        {
            context.Contactoes.AddOrUpdate(p => p.Name,
        new Contacto
        {
            Name = "Debra Garcia",
            Address = "1234 Main St",
            City = "Redmond",
            State = "WA",
            Zip = "10999",
            Email = "debra@example.com",
        },
         new Contacto
         {
             Name = "Thorsten Weinrich",
             Address = "5678 1st Ave W",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "thorsten@example.com",
         },
         new Contacto
         {
             Name = "Yuhong Li",
             Address = "9012 State st",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "yuhong@example.com",
         },
         new Contacto
         {
             Name = "Jon Orton",
             Address = "3456 Maple St",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "jon@example.com",
         },
         new Contacto
         {
             Name = "Diliana Alexieva-Bosseva",
             Address = "7890 2nd Ave E",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "diliana@example.com",
         }
         );
        }
    }
}

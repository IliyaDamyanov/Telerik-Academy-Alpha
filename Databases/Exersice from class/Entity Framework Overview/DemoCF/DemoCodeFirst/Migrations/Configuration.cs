namespace DemoCodeFirst.Migrations
{
    using DemoCodeFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<DemoCodeFirst.StudentSystemContext>
    {
        public Configuration()
        {
            //this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "DemoCodeFirst.StudentSystemContext";
        }

        protected override void Seed(DemoCodeFirst.StudentSystemContext context)
        {
            //v seed metoda se slagat samo neshta koito da se nabutat v bazata pri neinoto syzdavane. Sled tova neshtata ne se pylnqt v bazata ot tuk. Davame update-database v package manager cosole za da se kachat (bez add-migration).
            if (!context.Students.Any())
            {
                context.Students.Add(new Student()
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov"
                });
            }

        }
    }
}

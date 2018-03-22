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

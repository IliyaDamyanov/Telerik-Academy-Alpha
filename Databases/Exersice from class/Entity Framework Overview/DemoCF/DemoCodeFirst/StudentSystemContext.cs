using DemoCodeFirst.Migrations;
using DemoCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext() : base("name=StudentSystem")
        {
            var strategy = new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>();
            //Database.SetInitializer(strategy);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Mark> Marks { get; set; }

        public DbSet<Log> Logs { get; set; }
    }
}

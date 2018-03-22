namespace DemoCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedStudentsPropertyAgeToYearsOld : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TelerikStudents", name: "Age", newName: "YearsOld");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.TelerikStudents", name: "YearsOld", newName: "Age");
        }
    }
}

namespace DemoCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedStudentsTableToTelerikStudents : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Students", newName: "TelerikStudents");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TelerikStudents", newName: "Students");
        }
    }
}

namespace DemoCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDbSets : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CourseStudents", newName: "StudentCourses");
            DropPrimaryKey("dbo.StudentCourses");
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MyProperty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddPrimaryKey("dbo.StudentCourses", new[] { "Student_Id", "Course_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.StudentCourses");
            DropTable("dbo.Logs");
            AddPrimaryKey("dbo.StudentCourses", new[] { "Course_Id", "Student_Id" });
            RenameTable(name: "dbo.StudentCourses", newName: "CourseStudents");
        }
    }
}

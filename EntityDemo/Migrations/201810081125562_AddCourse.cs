namespace EntityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourse : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO COURSES (COURSE_NAME, SEMESTER) VALUES ('IT', 2)");
        }
        
        public override void Down()
        {
        }
    }
}

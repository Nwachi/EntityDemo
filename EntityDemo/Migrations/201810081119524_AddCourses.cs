namespace EntityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO COURSES (COURSE_NAME, SEMESTER) VALUES ('ADSE', 4)");
            Sql("INSERT INTO COURSES (COURSE_NAME, SEMESTER) VALUES ('ACNS', 4)");
            Sql("INSERT INTO COURSES (COURSE_NAME, SEMESTER) VALUES ('CPISM', 1)");
            Sql("INSERT INTO COURSES (COURSE_NAME, SEMESTER) VALUES ('DISM', 2)");
            Sql("INSERT INTO COURSES (COURSE_NAME, SEMESTER) VALUES ('IT', 1)");
        }
        
        public override void Down()
        {
        }
    }
}

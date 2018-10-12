namespace EntityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MODULES (Module_Name) values ('Web Dev')");
            Sql("INSERT INTO MODULES (Module_Name) values ('C#')");
            Sql("INSERT INTO MODULES (Module_Name) values ('Java')");
            Sql("INSERT INTO MODULES (Module_Name) values ('Networking')");
            Sql("INSERT INTO MODULES (Module_Name) values ('C++')");
        }
        
        public override void Down()
        {
        }
    }
}

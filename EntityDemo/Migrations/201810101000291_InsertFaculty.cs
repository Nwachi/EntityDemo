namespace EntityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertFaculty : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into faculties (Name, ModuleId)  values ('Mr. Breathrough', 2)");
            Sql("Insert into faculties (Name, ModuleId)  values ('Mr. Banky', 1)");
            Sql("Insert into faculties (Name, ModuleId)  values ('Mr. Paschal', 3)");
            Sql("Insert into faculties (Name, ModuleId)  values ('Mr. Cletus', 4)");
            Sql("Insert into faculties (Name, ModuleId)  values ('Mr. Paschal', 5)");
        }
        
        public override void Down()
        {
        }
    }
}

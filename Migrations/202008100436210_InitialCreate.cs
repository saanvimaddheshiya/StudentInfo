namespace Studentdetail1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student_Table1",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        First_Name = c.String(maxLength: 50),
                        Last_Name = c.String(maxLength: 50),
                        Class = c.String(maxLength: 50),
                        Subject = c.String(nullable: false, maxLength: 50),
                        Marks = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student_Table1");
        }
    }
}

namespace Studentdetail1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameSize : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student_Table1", "First_Name", c => c.String(nullable: false, maxLength: 22));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student_Table1", "First_Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}

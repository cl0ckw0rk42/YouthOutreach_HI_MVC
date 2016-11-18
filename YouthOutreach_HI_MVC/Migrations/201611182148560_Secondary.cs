namespace YouthOutreach_HI_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secondary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Donations", "Comments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Donations", "Comments");
        }
    }
}

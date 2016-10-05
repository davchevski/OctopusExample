namespace Football.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "City");
        }
    }
}

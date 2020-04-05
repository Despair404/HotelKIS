namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Types", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Types", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Types", "Photo");
            DropColumn("dbo.Types", "Cost");
        }
    }
}

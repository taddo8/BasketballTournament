namespace BasketballTournament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "PhoneNumber", c => c.String(nullable: false));
            
        }
        
        public override void Down()
        {
            
            AlterColumn("dbo.Teams", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}

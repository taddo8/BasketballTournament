namespace BasketballTournament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToUpdateDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Email", c => c.String(nullable: false));
        }
    }
}

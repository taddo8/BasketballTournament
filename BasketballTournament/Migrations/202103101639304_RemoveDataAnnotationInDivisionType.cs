namespace BasketballTournament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDataAnnotationInDivisionType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DivisionTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DivisionTypes", "Name", c => c.String(nullable: false));
        }
    }
}

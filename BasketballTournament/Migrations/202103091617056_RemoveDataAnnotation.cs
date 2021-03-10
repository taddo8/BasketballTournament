namespace BasketballTournament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDataAnnotation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "Division_Id", "dbo.Divisions");
            DropIndex("dbo.Teams", new[] { "Division_Id" });
            AlterColumn("dbo.Teams", "Email", c => c.String());
            AlterColumn("dbo.Teams", "Division_Id", c => c.Int());
            CreateIndex("dbo.Teams", "Division_Id");
            AddForeignKey("dbo.Teams", "Division_Id", "dbo.Divisions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Division_Id", "dbo.Divisions");
            DropIndex("dbo.Teams", new[] { "Division_Id" });
            AlterColumn("dbo.Teams", "Division_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Teams", "Email", c => c.String(nullable: false));
            CreateIndex("dbo.Teams", "Division_Id");
            AddForeignKey("dbo.Teams", "Division_Id", "dbo.Divisions", "Id", cascadeDelete: true);
        }
    }
}

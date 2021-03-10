namespace BasketballTournament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbSetDivisionTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DivisionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Divisions", "TimeSlots", c => c.String());
            AddColumn("dbo.Divisions", "DivisionType_Id", c => c.Int());
            AlterColumn("dbo.Divisions", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Divisions", "DivisionType_Id");
            AddForeignKey("dbo.Divisions", "DivisionType_Id", "dbo.DivisionTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Divisions", "DivisionType_Id", "dbo.DivisionTypes");
            DropIndex("dbo.Divisions", new[] { "DivisionType_Id" });
            AlterColumn("dbo.Divisions", "Name", c => c.String());
            DropColumn("dbo.Divisions", "DivisionType_Id");
            DropColumn("dbo.Divisions", "TimeSlots");
            DropTable("dbo.DivisionTypes");
        }
    }
}

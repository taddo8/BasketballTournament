namespace BasketballTournament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToUpdateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DivisionViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DivisionViewModels", "Team_Id", "dbo.Teams");
            DropIndex("dbo.DivisionViewModels", new[] { "Team_Id" });
            DropTable("dbo.DivisionViewModels");
        }
    }
}

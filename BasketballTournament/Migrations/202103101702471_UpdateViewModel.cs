namespace BasketballTournament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateViewModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DivisionViewModels", "Team_Id", "dbo.Teams");
            DropIndex("dbo.DivisionViewModels", new[] { "Team_Id" });
            DropColumn("dbo.DivisionViewModels", "Team_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DivisionViewModels", "Team_Id", c => c.Int());
            CreateIndex("dbo.DivisionViewModels", "Team_Id");
            AddForeignKey("dbo.DivisionViewModels", "Team_Id", "dbo.Teams", "Id");
        }
    }
}

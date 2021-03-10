namespace BasketballTournament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDivisionToViewModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DivisionViewModels", "Division_Id", c => c.Int());
            CreateIndex("dbo.DivisionViewModels", "Division_Id");
            AddForeignKey("dbo.DivisionViewModels", "Division_Id", "dbo.Divisions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DivisionViewModels", "Division_Id", "dbo.Divisions");
            DropIndex("dbo.DivisionViewModels", new[] { "Division_Id" });
            DropColumn("dbo.DivisionViewModels", "Division_Id");
        }
    }
}

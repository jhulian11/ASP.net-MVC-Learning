namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRentalModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Rental_Id", "dbo.Rentals");
            DropIndex("dbo.Movies", new[] { "Rental_Id" });
            RenameColumn(table: "dbo.Rentals", name: "CustomerId_Id", newName: "Customer_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_CustomerId_Id", newName: "IX_Customer_Id");
            AddColumn("dbo.Rentals", "Movie_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
            CreateIndex("dbo.Rentals", "Movie_Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
            DropColumn("dbo.Movies", "Rental_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Rental_Id", c => c.Int());
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "Movie_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_Customer_Id", newName: "IX_CustomerId_Id");
            RenameColumn(table: "dbo.Rentals", name: "Customer_Id", newName: "CustomerId_Id");
            CreateIndex("dbo.Movies", "Rental_Id");
            AddForeignKey("dbo.Movies", "Rental_Id", "dbo.Rentals", "Id");
        }
    }
}

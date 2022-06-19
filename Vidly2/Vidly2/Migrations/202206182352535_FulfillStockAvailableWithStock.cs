namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FulfillStockAvailableWithStock : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET AvailableStock = Stock");
        }
        
        public override void Down()
        {
        }
    }
}

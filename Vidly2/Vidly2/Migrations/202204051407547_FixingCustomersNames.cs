namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingCustomersNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Name = \'John Smith\' WHERE Id = 1 ");
            Sql("UPDATE Customers SET Name = \'Mary Monroe\' WHERE Id = 2 ");
            
        }
        
        public override void Down()
        {
        }
    }
}

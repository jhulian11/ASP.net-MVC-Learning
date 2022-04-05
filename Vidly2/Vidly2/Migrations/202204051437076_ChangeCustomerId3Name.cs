namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCustomerId3Name : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Name = \'Mary Monroe\' WHERE Id = 3 ");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToJohnSmith : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = \'2000-08-26\' WHERE Id = 1 ");
        }
        
        public override void Down()
        {
        }
    }
}

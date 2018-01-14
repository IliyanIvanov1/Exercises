namespace PetShopDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonAgeAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Age");
        }
    }
}
